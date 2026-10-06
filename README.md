# Projeto R — Vadronia

**Única implementação ativa: Unity 6.6 / C# / 2D top-down.**

## Começar em menos de 1 minuto

1. Leia [PROJECT_STATUS.md](PROJECT_STATUS.md) — estado atual e próximo foco.
2. Leia [AGENTS.md](AGENTS.md) — regras para editar sem quebrar o projeto.
3. Trabalhe em `unity/VadroniaDemo/`.
4. Para localizar código, consulte [ARCHITECTURE.md](unity/ARCHITECTURE.md).
5. Para decisões de sistema, consulte [MASTER_PROMPT.md](unity/docs/MASTER_PROMPT.md).

## Estrutura

```text
Projeto-R/
├─ README.md
├─ AGENTS.md
├─ PROJECT_STATUS.md
├─ unity/
│  ├─ README.md
│  ├─ HISTORY.md
│  ├─ ARCHITECTURE.md
│  ├─ docs/
│  │  ├─ MASTER_PROMPT.md
│  │  └─ PROJECT_BIBLE.txt
│  └─ VadroniaDemo/          # projeto Unity real
├─ docs/
│  ├─ README.md
│  ├─ WORKFLOW.md
│  ├─ PROJECT_FOUNDATIONS.md
│  ├─ lore/
│  │  └─ LORE_BIBLE.txt
│  └─ references/            # imagens e referências visuais
└─ assets/
   ├─ music/
   └─ videos/
```

## Regra simples

- `main` = versão integrada.
- uma tarefa = uma branch.
- Unity é o único projeto jogável.
- lore, imagens, música e vídeo ficam nas fontes canônicas da raiz.
- preserve `.meta`, GUIDs, saves e assets aprovados.
- não declare teste/compilação sem executar.
- não gere build Windows sem pedido explícito.
