Esse repositório serve para documentar qualquer tipo de tecnologia estudada durante meu curso em programação com o objetivo de melhorar minhas ferramentas quando o assunto
é programar projetos futuros. Talvez vire também uma biblioteca.

Aqui segue uma cópia do README de cada pasta:

[ConsoleDeDados]
Esse é um console de ordendação de dados com ponteiro feito num trabalho da faculdade, aqui tem a ordem principal de ponteiro que eu
uso para meus programas que tem esse tipo de ordenação.

[FilaDeCarros]
Código regaçado que faz uma fila de carros usando classes com ponteiros. Funciona. Não está completo mas a lógica foi executada
com sucesso o7.

[PonteiroEficienteLista]
O negócio é o seguinte: esse é o melhor método de ponteiro que eu já vi, funciona pra qualquer
tipo de lista que você quiser, e tecnicamente para qualquer outro método de ponteiro também.

Funciona em 2 passos EXTREMAMENTE simples que fazem funcionar igual mágica, nem seu qual colega
que fez de tão fluido.

PASSO 1 - Sentinelas

Ao criar o sistema encadeado por ponteiro, a lista possuirá 2 "sentinelas": primeiro e último. Esses
sentinelas funcionam como base pro resto dos elementos, pulando linhas e linhas de código que tentam
peneirar a lógica inicial.
Aqui está o pulo do gato: na lista, é essencial ter um construtor que iguala o início com o fim e com
um novo elemento vazio como mostra a seguir:

public lista
{
    primeiro = ultimo = new elemento()
}

NÃO ME PERGUNTE PORQUE mas isso simplemente automatiza toda aquela lógica condicional chata dos códigos
de ponteiro (if primeiro.prox == null blá blá blá). Pronto! Com essas 2 linhas os elementos vão interagir
com os sentinelas sem mais esforços, tentei entender a razão mas desisti. Sinta-se livre para dar commit
na explicação se souber, fiquei muito tempo pesquisando e me recusando a perguntar pro GPT.

PASSO 2 - Inserir Final

Junto com esse construtor, é importante fazer uma função separada que coloca um elemento novo no final 
interagindo com o "ultimo". Super simples:

public void InserirFim(elemento x)
{
    ultimo.prox = x;
    ultimo = ultimo.prox;
}

Novamente, é meio confuso pelo fato da extrema simplicidade, mas apenas confia, funciona.

Pronto! com essas 2 funções dentro a classe da lista você pode começar inserindo normalmente elementos 
usando qualquer função que retorne um elemento preenchido, aqui vai um exemplo:

main
{
    elemento novoelemento = minhalista.CRIARELEMENTO();       //CRIARELEMENTO() é uma função imaginária que retorna um elemento preenchido
    minhalista.InserirFinal(novoelemento);                    //InserirFinal() é o passo 2.
}

É isso! Tão simples que dá pra decorar de cabeça.
Com isso não precisa nem fazer exceções caso a lista tá vazia.




NOTA GERAL:
-> Para transformar o aplicativo de console em um .exe, use o seguinte comando de console dentro da pasta do projeto desejado: dotnet publish -c Release -r win-x64 /p:PublishSingleFile=true
Fique ciente que isto inclui apenas o executável, ou seja, para a importação completa é necessário criar uma pasta adequada contendo todas as possíveis exigências, igualzinho um videogame.
