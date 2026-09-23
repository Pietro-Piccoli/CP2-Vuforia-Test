# CP2 — Realidade Aumentada com Vuforia (Unity)

Experiência de Realidade Aumentada feita em Unity com o Vuforia Engine. A câmera
reconhece um **Image Target** (uma foto de um tigre) e, sobre ela, exibe um
**cubo 3D**. O usuário pode **girar o cubo arrastando** o dedo (celular) ou o
mouse (no Editor).

## Link do repositório
https://github.com/Pietro-Piccoli/CP2-Vuforia-Test

## O que o projeto faz (requisitos da avaliação)
- **Reconhecimento de Image Target:** alvo "tigre" (base de dados `avaliacao_ar`), nota 5 estrelas no Vuforia.
- **Modelo 3D no AR:** um cubo aparece em cima do alvo quando ele é reconhecido.
- **Interação programada em C#:** o script `Assets/Scripts/CuboInterativo.cs` gira o cubo conforme o arraste do usuário (toque no celular ou clique-e-arraste no Editor).

## Como abrir e testar
1. Abrir o projeto no **Unity 6000.4.6f1** (Unity Hub → Add → selecionar a pasta do projeto).
2. Abrir a cena `Assets/Scenes/SampleScene.unity`.
3. Apertar **Play**.
4. Mostrar a **imagem do tigre** para a webcam (arquivo `IMAGEM_ALVO_tigre.jpg`, incluído — pode abrir no celular em tela cheia ou imprimir).
5. Quando o Vuforia reconhecer o tigre, o **cubo laranja** aparece sobre ele.
6. **Clicar e arrastar** sobre o cubo para girá-lo.

## Detalhes técnicos
- **Unity:** 6000.4.6f1
- **Vuforia Engine:** 11.4.4 (incluído em `Packages/`, versionado via Git LFS)
- **Render Pipeline:** Built-in
- **Input:** Input System (novo)
- A license key do Vuforia já está configurada no projeto.

## Estrutura principal
- `Assets/Scripts/CuboInterativo.cs` — script da interação (rotação por arraste).
- `Assets/Scenes/SampleScene.unity` — cena com ARCamera + Image Target + cubo.
- `Assets/StreamingAssets/Vuforia/` — base de dados do alvo (tigre).
- `IMAGEM_ALVO_tigre.jpg` — a imagem que deve ser mostrada para a câmera.
