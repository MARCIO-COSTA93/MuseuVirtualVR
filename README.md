# Museu Virtual VR - Antigo Egito

## Aluno
Marcio Oliveira — Web 3.0 Residência em TIC 29

## Descrição
Experiência de Realidade Virtual ambientada no Antigo Egito, desenvolvida com Unity 6 e Meta Quest 3. O usuário pode explorar um museu virtual com estátuas e artefatos egípcios reais escaneados de museus ao redor do mundo.

## Contexto no Metaverso
Este projeto representa um espaço cultural imersivo no Metaverso — um museu virtual acessível a qualquer pessoa com um headset VR. O visitante pode interagir com artefatos históricos reais que normalmente só poderiam ser vistos em museus físicos.

## Tecnologias Utilizadas
- Unity 6 (6000.3.9f1)
- XR Interaction Toolkit v3.4.0
- OpenXR
- Meta Quest 3
- Universal Render Pipeline (URP)
- C#

## Assets Utilizados
- Ancient Egypt Pack — suspishus (Sketchfab) — CC Attribution
- Egypt Props Pack — PolyOne Studio (Sketchfab) — CC Attribution
- Egyptian Cat Statue (Bastet) — Ankledot (Sketchfab) — CC Attribution

## Estrutura do Repositório
- Assets/Scenes — Cena principal do museu
- Assets/Scripts — Script de interação ArtifactInfoPanel.cs
- Assets/Models — Modelos 3D dos artefatos
- ProjectSettings — Configurações do projeto
- Packages — Pacotes Unity

## Como Executar
1. Clone o repositório
2. Abra no Unity 6
3. Instale XR Interaction Toolkit e OpenXR via Package Manager
4. Conecte o Meta Quest 3 via USB
5. File → Build and Run

## Dificuldades Encontradas
- Configuração do OpenXR para Meta Quest 3
- Importação de modelos GLB com Unity glTFast
- Posicionamento dos artefatos no espaço 3D( ainda estou ajustando,e colocarei mais artefatos)
