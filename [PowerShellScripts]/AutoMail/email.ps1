$outlook = New-Object -ComObject Outlook.Application
$mail = $outlook.CreateItem(0)
$dados = Import-Csv (Join-Path $PSScriptRoot "MailList.csv")

foreach ($linha in $dados) {
		
 	.\email2 $linha.Email
}
