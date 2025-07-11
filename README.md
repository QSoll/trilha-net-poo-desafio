## Simulador - Instalação de App por Modelo de Celular

Este projeto em C# simula a instalação de aplicativos em diferentes modelos de celular.

Exemplos usados: **Nokia** e **iPhone**

## Funcionalidades

- Identificação de modelo e aplicativos a instalar
- Verificação de compatibilidade
- Relatório visual de apps instalados e rejeitados
- Tela final estilizada com animação de assinatura 💛

## Tecnologias utilizadas

- C# com .NET Core/Framework
- Uso de `Dictionary<string, List<string>>` para organização dos dados
- Animação com `Thread.Sleep()` para efeitos de terminal
- Manipulação de cores no console (`ConsoleColor`)
- Escrita centralizada no terminal via método personalizado `CenteredWrite`

Saída final no terminal:
Data: 10/07/2025 - Hora: 22:17:00

Iniciando instalação de aplicativos no Nokia...
Instalando WhatsApp... concluído.
Instalando Telegram... concluído.
Instalando Nokia 1280 Launcher... concluído.
Instalando Facetime... concluído.
Finalizando...

Instalação realizada Nokia: WhatsApp, Telegram, Nokia 1280 Launcher

Incompatibilidade encontrada. Não instalado: Nokia: Facetime

Desenvolvido por Sol Morcillo 💛

----------------------------------------------------------------------

Curtiu o projeto? 

Sinta-se à vontade para aprimorar com mais modelos ou recursos visuais como barra de progresso ou sons! 

Até mais !!!

<img src="https://solmorcillo.com.br/imgs_public/logo_SM.jpg" width="50px" height="60px">

---------------------------------------------------------------------

<img src="https://solmorcillo.com.br/imgs_public/logo_wex.jpg" width="55px" height="35px"> e <img src="https://solmorcillo.com.br/imgs_public/logo_dio.jpg" width="55px" height="35px"> - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
