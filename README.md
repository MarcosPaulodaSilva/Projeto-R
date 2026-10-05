# Projeto R — Vadronia

O repositório está organizado em **duas implementações** e uma área **compartilhada**.

| Área | Caminho | Função |
|---|---|---|
| **Unity — desenvolvimento atual** | [unity/](unity/README.md) | Projeto ativo em Unity 6.6 / C#. |
| **HTML — histórico jogável** | [html/](html/README.md) | Linha de navegador preservada até a v0.16.1. |
| **Documentação compartilhada** | [docs/](docs/README.md) | Lore, referências visuais e regras comuns. |
| **Assets compartilhados** | [assets/](assets/README.md) | Música, vídeos de referência e manifestos. |

## Estrutura

```text
Projeto-R/
├─ unity/
│  ├─ VadroniaDemo/          # Projeto Unity real
│  ├─ docs/
│  │  ├─ design/             # Design e pré-produção específicos da Unity
│  │  ├─ shared/             # Cópias locais das informações compartilhadas
│  │  └─ platform-reference/ # Estado mais recente da linha HTML
│  └─ project-state/         # Histórico e validações da Unity
├─ html/
│  ├─ builds/                # Builds históricas do navegador
│  ├─ docs/
│  │  ├─ prompts/            # Prompt mestre histórico do HTML
│  │  ├─ shared/             # Cópias locais das informações compartilhadas
│  │  └─ platform-reference/ # Estado atual da implementação Unity
│  ├─ project-state/         # Estados por versão HTML
│  └─ reports/               # Auditorias históricas
├─ docs/
│  ├─ lore/                  # Lore canônico
│  ├─ references/            # Referências visuais
│  └─ shared/                # Índice de material entre plataformas
└─ assets/
   ├─ music/                 # Contexto e manifesto das trilhas
   └─ videos/                # Vídeos de referência e manifesto
```

## Versões atuais

- **Unity:** desenvolvimento ativo em `unity/VadroniaDemo`.
- **HTML:** [v0.16.1](html/builds/v0.16/projeto-r-v0.16.1-vadronia.html).

As duas implementações têm código e estado próprios. Lore, identidade do mundo, referências de arte e contexto de áudio são compartilhados. Para evitar perda de informação ao trabalhar apenas dentro de uma plataforma, os documentos essenciais também são copiados em `unity/docs/shared/` e `html/docs/shared/`.

Na máquina de Marcos, o projeto Unity já aberto no Editor continua em `C:/Users/Marcos/Downloads/VadroniaDemo`. A organização do GitHub não exige mover essa pasta.

Não gerar executáveis ou pacotes Windows sem pedido explícito.
