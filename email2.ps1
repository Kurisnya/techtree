$outlook = New-Object -ComObject Outlook.Application
$mail = $outlook.CreateItem(0)
$dados = Import-Csv "C:\Users\christian.soares\bin\AutoMail\MailList.csv"

	$email = $linha.Email

	$mail.To = $($args[0])
	$mail.Subject = "Teste"
	$mail.Body = "testando 123"

	$mail.Send()