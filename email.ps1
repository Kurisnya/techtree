$outlook = New-Object -ComObject Outlook.Application
$mail = $outlook.CreateItem(0)
$dados = Import-Csv "C:\Users\christian.soares\bin\AutoMail\MailList.csv"

foreach ($linha in $dados) {
		
 	email2 $linha.Email
}
