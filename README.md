# Projeto R — Vadronia

Este repositório contém **uma única implementação ativa: Unity**.

## Comece aqui

Para continuar o desenvolvimento sem perder contexto entre ChatGPT, Codex/Cloud e trabalho local:

1. [Regras para agentes](AGENTS.md)
2. [Painel operacional atual](PROJECT_STATUS.md)
3. [Workflow de colaboração](docs/WORKFLOW_AGENTS.md)
4. [Estado atual da Unity](unity/VadroniaDemo/PROJECT_STATE.md)
5. [Super Master Prompt — Unity](unity/docs/prompts/super-master-prompt-projeto-r-unity.md)

A `main` é a fonte canônica integrada. Cada tarefa deve partir dela em uma branch própria e voltar por pull request.

| Área | Caminho | Função |
|---|---|---|
| **Unity** | [unity/](unity/README.md) | Projeto ativo em Unity 6.6 / C#. |
| **Documentação canônica** | [docs/](docs/README.md) | Lore, design, regras e referências visuais. |
| **Assets de referência** | [assets/](assets/README.md) | Música, vídeos de referência e manifestos. |

## Estrutura

```text
Projeto-R/
├─ AGENTS.md                 # Regras obrigatórias para agentes
├─ PROJECT_STATUS.md         # Estado operacional/handoff canônico
├─ unity/
│  ├─ VadroniaDemo/          # Projeto Unity real
│  ├─ docs/
│  │  ├─ design/             # Bíblia de pré-produção e arquitetura Unity
│  │  └─ prompts/            # Prompt operacional canônico
│  └─ project-state/         # Histórico e validações da Unity
├─ docs/
│  ├─ WORKFLOW_AGENTS.md     # Colaboração entre agentes
│  ├─ lore/                  # Lore canônico
│  ├─ references/            # Imagens e referências visuais
│  └─ shared/                # Fundamentos de design do Projeto R
└─ assets/
   ├─ music/                 # Música e contexto de uso
   └─ videos/                # Vídeos de referência
```

## Regra de preservação

Materiais úteis de protótipos anteriores foram consolidados na documentação do Unity, especialmente na Bíblia de pré-produção, no Super Master, no lore e nas referências visuais. Não recrie implementações antigas nem mantenha documentação duplicada quando já existir uma fonte canônica atual.

Na máquina de Marcos, o projeto Unity já aberto no Editor continua em `C:/Users/Marcos/Downloads/VadroniaDemo`. A organização do GitHub não exige mover essa pasta.

Não gerar executáveis ou pacotes Windows sem pedido explícito.
