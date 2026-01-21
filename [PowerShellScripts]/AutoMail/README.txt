Introdução
Estes são scripts que automatizam o disparo de e-mails para outros colaboradores, usando o outlook.

Modo de uso
1. Escreva o assunto dos e-mails:
No script "email2.ps1" encontre a linha "$mail.Subject = " e preencha-o com o assunto desejado entre aspas duplas, como no exemplo:

	$mail.Subject = "Meu assunto"
	
	Salve o arquivo com CTRL + S;

2. Redija o corpo do texto:
Abra o arquivo localizado em Assinatura\Assinatura.html e abra-o como texto, usando Botão Direito > Abrir com > Bloco de Notas e edite o campo marcado como CORPO DO TEXTO em html. Segue um breve manual dos elementos html para boa edição do texto, os "TEXTO" em caixa alta são apenas exemplos:

<p> TEXTO </p>  --> Parágrafo
<a href="LINK.COM"> TEXTO </a> --> Link externo acessado ao clicar no TEXTO de exemplo

	Salve o arquivo com CTRL + S;

3. Assine os e-mails:
No mesmo arquivo do passo 2, coloque seu nome no campo marcado "SUA ASSINATURA".

	Salve o arquivo com CTRL + S;

4. Liste os endereços de e-mail alvos:
Abra o arquivo MailList.csv e coloque os endereços para os e-mails lançados pelo script, faça-o seguindo o exemplo:

Email
exemplo1@123.com
exemplo2@432.com
exemplo4@exemplo.com

	Salve o arquivo com CTRL +S;

5. Lançar e-mails:
Após completar os passos anteriores, execute o script "email.ps1" usando o PowerShell, faça isso com Botão Direito > Executar com o PowerShell.


Aguarde os e-mails serem enviados.
