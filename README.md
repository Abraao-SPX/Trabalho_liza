Trabalho: Árvores Hierárquicas e Recursividade
Este projeto foi desenvolvido para a disciplina de Estrutura de Dados da UNINASSAU. O objetivo é demonstrar o funcionamento de Árvores e Algoritmos Recursivos em C# através de um problema prático de negócio.

Sobre o Projeto
O código resolve o problema do "Cálculo de Bônus Hierárquico".

Regra: O bônus de um chefe é a média aritmética do bônus de seus subordinados diretos.

Solução: O algoritmo percorre a árvore de funcionários (de baixo para cima) usando recursividade para calcular as médias.

Além do código, este projeto serve como base para a peça/vídeo explicativo apresentado pelo grupo.

Cenário da Simulação
Para demonstrar a lógica, criamos a seguinte hierarquia no Main:

                      [CEO]
                   /        \
            [Gerente]        [Diretor]
           /       \      (Valor: 3.500)
     [Vendendor 1] [Vendendor 2]
     (Valor: 1.000) (Valor: 2.000)

 
Resultados Esperados:

Gerente: Média entre 1000 e 2000 = 1.500

CEO: Média entre Gerente (1500) e Diretor (3500) = 2.500

Tecnologias
Linguagem: C# (.NET)

Conceitos: POO, Listas, Árvores Hierárquicas e Recursividade.


Grupo:

Yuri Cruz Brandão - 16036094
Pedro Henrique de Souza Santos - 16035878
Abraão Silva Paixão - 16035780
Franklyn dos Santos Silva - 16025102
Paulo Rafael cardoso santos - 16035887
