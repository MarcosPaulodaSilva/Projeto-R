# AGENTS — Projeto R

## Ordem obrigatória

1. Leia `PROJECT_STATUS.md`.
2. Leia `unity/VadroniaDemo/PROJECT_STATE.md`.
3. Edite somente a partir de uma branch criada da `main` atual.
4. Se a tarefa mexer em sistemas/design, leia `unity/docs/MASTER_PROMPT.md`.
5. Se mexer em código, use `unity/ARCHITECTURE.md` para escolher o módulo.
6. Se mexer em cânone/lore, leia `docs/lore/LORE_BIBLE.txt`.

## Regras que não podem ser quebradas

- Projeto ativo: Unity 6.6 / 6000.6.0f1, C#, 2D top-down ortogonal, Built-in pipeline.
- Projeto no repositório: `unity/VadroniaDemo`.
- Projeto aberto no PC de Marcos: `C:/Users/Marcos/Downloads/Projeto R/Projeto R Vadrônia Demo`.
- O nome/caminho local e o caminho do GitHub são intencionalmente diferentes; não renomeie a pasta do repositório só para imitar o Windows.
- Preserve `.meta`, GUIDs, saves, cenas e assets aprovados.
- Não recrie sistemas já existentes sem antes inspecionar o código.
- Não crie fontes duplicadas de verdade: atualize os documentos canônicos.
- Não afirmar “testado”, “compilado” ou “integrado” sem verificação real.
- Não gerar executável/pacote Windows sem pedido explícito de Marcos.
- Respeite a separação `Core / Player / World / UI / Visual / Bootstrap`; não crie pasta nova sem código real que justifique um módulo.
- Runtime não pode depender de `Assets/Editor`.
- Mudanças na lógica coberta por `Tests/Regression.csproj` devem manter o workflow de regressão verde; isso não substitui validação Unity/Play Mode.
- Se o estado do jogo mudar, atualize `PROJECT_STATUS.md` e `unity/VadroniaDemo/PROJECT_STATE.md`.

## Handoff

PRs devem informar: objetivo, arquivos alterados, testes executados, o que não foi validado, riscos e próximo passo.
