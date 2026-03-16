# Museu Virtual VR - Antigo Egito

## Aluno

Marcio da Costa Oliveira — Web 3.0 Residência em TIC 29

## Descrição

Experiência de Realidade Virtual ambientada no Antigo Egito, desenvolvida com Unity 6 e Meta Quest 3. O usuário pode explorar um museu virtual com estátuas e artefatos egípcios, interagir com os objetos e visualizar informações históricas em painéis VR.

## Contexto no Metaverso

Este projeto representa um espaço cultural imersivo no Metaverso — um museu virtual acessível a qualquer pessoa com um headset VR. O visitante pode interagir com artefatos históricos que normalmente só poderiam ser vistos em museus físicos ao redor do mundo.

## Tecnologias Utilizadas

* Unity 6 (6000.3.9f1)
* XR Interaction Toolkit v3.4.0
* OpenXR v1.16.1
* Meta Quest 3
* Universal Render Pipeline (URP)
* Unity glTFast 6.16.1
* C#

## Funcionalidades

* Ambiente 3D completo com paredes, chão e teto texturizados
* 4 artefatos egípcios posicionados no museu
* Painel de informações ao interagir com artefatos
* Iluminação ambiente com 3 luzes quentes
* Teleporte pelo museu (XR Locomotion)

## Assets 3D Utilizados

* **Anubis** — Átila Becker
https://sketchfab.com/3d-models/anubis-f7879a5a7d9e47dd9c79a5eb94a7325d
Licença: CC Attribution
* **Egyptian Cat Statue (Bastet)** — Ankledot
https://sketchfab.com/3d-models/egyptian-cat-statue
Licença: CC Attribution
* **Egyptian Statue** — Rob Allen
https://sketchfab.com/3d-models/egyptian-statue-223b17c1ae274a93b87cde56c150166a
Licença: CC Attribution
* **Horus Falcon** — The British Museum
Licença: CC Attribution-NonCommercial-ShareAlike

## Texturas Utilizadas

* **Marble 01** — Poly Haven
https://polyhaven.com/a/marble\_01
Licença: CC0 (domínio público)
* **Old Stone Wall** — Poly Haven
https://polyhaven.com/a/old\_stone\_wall
Licença: CC0 (domínio público)

## Estrutura do Repositório

* Assets/Scenes — Cena principal do museu
* Assets/Scripts — Script de interação ArtifactInfoPanel.cs
* Assets/Models — Modelos 3D dos artefatos
* Assets/Materials — Materials com texturas aplicadas
* Assets/Texturas — Texturas do ambiente
* ProjectSettings — Configurações do projeto
* Packages — Pacotes Unity

## Como Executar

1. Clone o repositório
2. Abra no Unity 6
3. Instale XR Interaction Toolkit e OpenXR via Package Manager
4. Conecte o Meta Quest 3 via USB
5. File → Build and Run

## Dificuldades Encontradas

* Configuração do OpenXR para Meta Quest 3
* Importação de modelos GLB com Unity glTFast
* Posicionamento e escala dos artefatos no espaço 3D
* Configuração do sistema de teleporte no Unity 6

