# Projeto R — Vadronia

As versões Unity e HTML estão separadas em duas pastas neste repositório.

| Projeto | Pasta | Como abrir |
|---|---|---|
| **Unity — desenvolvimento atual** | [unity/](unity/README.md) | Adicione `unity/VadroniaDemo` no Unity Hub e abra com Unity 6.6. |
| **HTML — navegador e histórico** | [html/](html/README.md) | Baixe e abra o [HTML v0.16.1](html/builds/v0.16/projeto-r-v0.16.1-vadronia.html) no navegador. |

## Organização

```text
Projeto-R/
├─ unity/
│  ├─ VadroniaDemo/       # Projeto Unity: Assets, Packages e ProjectSettings
│  ├─ docs/              # Documentação específica de Unity
│  └─ project-state/     # Continuação e validações locais de Unity
├─ html/
│  ├─ builds/            # HTMLs originais, incluindo v0.16.1
│  ├─ docs/              # Prompts históricos da versão HTML
│  ├─ project-state/     # Estados históricos da versão HTML
│  └─ reports/           # Auditorias da versão HTML
├─ docs/                 # Lore e referências visuais compartilhadas
└─ assets/               # Documentação e manifesto de áudio compartilhados
```

As versões têm implementações e estados de desenvolvimento diferentes. A Unity atual é 2D top-down ortogonal, com exploração de Grünwald, corrida, esquiva e uma missão de Conrad. O HTML preserva a linha histórica v0.16.1; sua numeração não representa a versão Unity.

O projeto local já aberto no Editor continua em `C:/Users/Marcos/Downloads/VadroniaDemo`. A organização do GitHub não exige mover essa pasta.

As versões HTML, os assets Unity e os GUIDs foram preservados. O histórico Git anterior à separação permanece disponível. Não gerar executáveis ou pacotes Windows sem novo pedido explícito de Marcos.

[Lore e referências compartilhadas](docs/README.md) · [Manifesto de áudio](assets/music/README.md)
