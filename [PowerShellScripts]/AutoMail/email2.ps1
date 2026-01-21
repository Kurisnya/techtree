
$outlook = New-Object -ComObject Outlook.Application
$namespace = $outlook.GetNamespace("MAPI")

$mail = $outlook.CreateItem(0)
$dados = Import-Csv (Join-Path $PSScriptRoot "MailList.csv")

$attachmentPath = Join-Path $PSScriptRoot "Assinatura\iteamlogo.gif"
$attachment = $mail.Attachments.Add($attachmentPath,1,0)

$attachment.PropertyAccessor.SetProperty(
	"http://schemas.microsoft.com/mapi/proptag/0x3712001F",
	"logo1"	
)

$attachment2Path = Join-Path $PSScriptRoot "Assinatura\iteamPart2.png"
$attachment2 = $mail.Attachments.Add($attachment2Path,1,0)

$attachment2.PropertyAccessor.SetProperty(
	"http://schemas.microsoft.com/mapi/proptag/0x3712001F",
	"logo2"
)

$attachment3Path = Join-Path $PSScriptRoot "Assinatura\iteamPart3.png"
$attachment3 = $mail.Attachments.Add($attachment3Path,1,0)

$attachment3.PropertyAccessor.SetProperty(
	"http://schemas.microsoft.com/mapi/proptag/0x3712001F",
	"logo3"
)

$mail.To = $($args[0])
$mail.Subject = "TESTE OFICIAL"


$htmlTrue = Get-Content (Join-Path $PSScriptRoot "Assinatura\Assinatura.html") -Raw

$mail.HTMLBody = "`r`n" + $htmlTrue

$mail.Send()