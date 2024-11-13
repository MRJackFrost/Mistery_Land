# Mistery_Land
Desenvolvimento do Projeto

MisteryLands

Bruno Martins

Lógica:
 No desenvolvimento do jogo foi feito alguns códigos principais que fazem o jogo rodar, temos duas instâncias que iniciam na primeira Cena de Menu sendo um “GameManager” e um “SoundManager”, em cada cena eu tenho um “SoundCheck” para controlar as músicas e efeitos dentro da instância do SoundManager.
Na minha cena de Menu eu tenho a implementação do Unity Ads com os códigos da documentação que o inicializa e instancia um interstitial ads.
Na minha cena do Jogo eu tenho como principal o Script de combate e status, que faz com que eu possa instanciar qualquer inimigo e ter um combate com ele, no jogo eu só tenho um como exemplo mas a ideia é funcionar com qualquer inimigo que tiver uma área como collider e seu Status, só é possível passar da fase se for completado duas missões que ficam salvas na instância do nosso GameManager, além disso eu tenho o sistema de movimentação do player que foi feito com o novo sistema de input da unity que me permite usar o teclado e o touch.
Na minha cena de vitória eu carrego no meu canvas os dados presentes no meu GameManager, mostrando o tempo na cena anterior e os dados da batalha como quantas vezes você usou a habilidade de escudo e quanto dano você tomou no total, meu botão de voltar ao menu tem duas funções, a de LoadScene para retornar a cena e um ResetAll() presente na instância do meu GameManager, que reseta seus dados.


Tempo gasto: 
Consegui trabalhar cerca de 3 dias no projeto, 6 horas no sábado, 10 horas no domingo e 6 horas na segunda, totalizando 22 horas até a build final estar rodando em um sistema android.


Dificuldade: 
Tive durante o projeto duas principais dificuldades, a primeira era relacionado ao gradle da unity quando era efetuada uma tentativa de build, me tomou algumas horas para descobrir que a unity não estava gerando o arquivo gradlew.bat, assim ela não conseguia gerar algumas referência para build em android, além disso tive problemas com o Multi touch utilizando dois botões para a movimentação e pulo que uma hora funcionava e outra não, apesar de várias pesquisas só descobri que isso era um problema com o novo sistema de input da unity mas não encontrei uma solução, sendo assim resolvi deixar apenas um botão que faz a função de pulo assim que o Y chega ao determinado valor porém não faz o player voar se segurar para cima, Esses problemas foram os que me tomaram mais tempo.

