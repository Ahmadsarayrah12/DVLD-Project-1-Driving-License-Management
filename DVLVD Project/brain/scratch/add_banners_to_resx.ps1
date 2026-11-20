$iconsDir64 = "c:\Users\ahmad\Desktop\DVLD Driving License Management\assets\icons\Extended_100\64px"
$iconsDir16 = "c:\Users\ahmad\Desktop\DVLD Driving License Management\assets\icons\Extended_100\16px"

Add-Type -AssemblyName System.Drawing

function ImageToBase64($path) {
    $img = [System.Drawing.Image]::FromFile($path)
    $ms = New-Object System.IO.MemoryStream
    $img.Save($ms, [System.Drawing.Imaging.ImageFormat]::Png)
    $bytes = $ms.ToArray()
    $ms.Dispose()
    $img.Dispose()
    return [Convert]::ToBase64String($bytes)
}

$bVision = ImageToBase64 "$iconsDir64\Banner_Vision_Test.png"
$bWritten = ImageToBase64 "$iconsDir64\Banner_Written_Test.png"
$bStreet = ImageToBase64 "$iconsDir64\Banner_Street_Test.png"
$bEdit = ImageToBase64 "$iconsDir16\CMS_Edit.png"

$targetResxFiles = @(
    "c:\Users\ahmad\Desktop\DVLD Driving License Management\DVLVD Project\Applications\LocalDrivingLicense\Tests\frmTestAppointments.resx",
    "c:\Users\ahmad\Desktop\DVLD Driving License Management\DVLVD Project\Applications\LocalDrivingLicense\Tests\frmScheduleTest.resx",
    "c:\Users\ahmad\Desktop\DVLD Driving License Management\DVLVD Project\Applications\LocalDrivingLicense\Tests\frmTakeTest.resx"
)

foreach ($f in $targetResxFiles) {
    $content = [System.IO.File]::ReadAllText($f, [System.Text.Encoding]::UTF8)
    $content = $content.TrimEnd()
    if ($content.EndsWith("</root>")) {
        $content = $content.Substring(0, $content.LastIndexOf("</root>"))
    }
    
    $sb = New-Object System.Text.StringBuilder
    $sb.Append($content) | Out-Null
    
    if (-not $content.Contains("name=`"Banner_Vision_Test`"")) {
        $sb.AppendLine(@"
  <data name="Banner_Vision_Test" type="System.Drawing.Bitmap, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
    <value>$bVision</value>
  </data>
"@) | Out-Null
    }
    if (-not $content.Contains("name=`"Banner_Written_Test`"")) {
        $sb.AppendLine(@"
  <data name="Banner_Written_Test" type="System.Drawing.Bitmap, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
    <value>$bWritten</value>
  </data>
"@) | Out-Null
    }
    if (-not $content.Contains("name=`"Banner_Street_Test`"")) {
        $sb.AppendLine(@"
  <data name="Banner_Street_Test" type="System.Drawing.Bitmap, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
    <value>$bStreet</value>
  </data>
"@) | Out-Null
    }

    if ($f.EndsWith("frmTestAppointments.resx") -and -not $content.Contains("name=`"editAppointmentToolStripMenuItem.Image`"")) {
        $sb.AppendLine(@"
  <data name="editAppointmentToolStripMenuItem.Image" type="System.Drawing.Bitmap, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
    <value>$bEdit</value>
  </data>
"@) | Out-Null
    }

    $sb.AppendLine("</root>") | Out-Null
    [System.IO.File]::WriteAllText($f, $sb.ToString(), [System.Text.Encoding]::UTF8)
}
Write-Host "Updated banners in test resx files!"
