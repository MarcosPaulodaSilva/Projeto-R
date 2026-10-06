# PROJECT_STATUS — painel operacional canônico

> Leia este arquivo depois de `AGENTS.md` antes de começar qualquer tarefa no Projeto R.

## Regra principal

- A branch `main` é a fonte canônica de progresso integrado.
- Unity é a implementação ativa.
- HTML é histórico jogável preservado e não deve ser tratado como a implementação atual.
- Não use uma branch `codex/*` antiga como base sem comparar com `main`.
- Toda tarefa que alterar comportamento, arte integrada, documentação operacional ou estado validado deve atualizar este arquivo no mesmo PR.

## Estado observado

- Repositório: `MarcosPaulodaSilva/Projeto-R`
- Branch canônica: `main`
- Implementação ativa: `unity/VadroniaDemo`
- Engine: Unity 6.6 / 6000.6.0f1
- Direção atual: 2D top-down ortogonal, C#, Built-in pipeline
- Estado técnico detalhado: `unity/VadroniaDemo/PROJECT_STATE.md`
- Histórico de validação/local: `unity/project-state/unity-local-2026-10-04.md`
- Prompt operacional Unity: `unity/docs/prompts/super-master-prompt-projeto-r-unity.md`

## Último estado validado

Em 05/10/2026, a documentação do projeto registra como implementados no Unity: terreno atualizado, personagens com pernas animadas independentemente, ambientação, câmera suave, HUD em UI Toolkit, corrida/fôlego, esquiva, interação com Conrad, coleta de três ervas, recompensa única de 25 moedas e save local.

Validações registradas: 20 verificações de lógica + 11 verificações em Play aprovadas.

Limites registrados: prédios ainda externos, um NPC, sem combate e sem interiores.

## Foco atual

Priorizar evolução da implementação Unity existente sem misturar a linha HTML. Antes de expandir escopo, preservar o funcionamento validado, arquivos `.meta`, GUIDs, saves e assets já integrados.

## Fila operacional

Use esta ordem salvo instrução mais recente de Marcos:

1. continuar a atualização visual/animação já autorizada;
2. manter a caminhada com passos baixos e alternância real das duas pernas;
3. evoluir mecânicas apenas sobre a base Unity validada;
4. validar no Editor e registrar o que foi realmente testado;
5. atualizar este painel e `unity/VadroniaDemo/PROJECT_STATE.md` quando o estado do jogo mudar.

## Handoff entre agentes

Ao terminar uma tarefa:

1. trabalhe em branch nova criada a partir de `main`;
2. faça commits pequenos e descritivos;
3. atualize `PROJECT_STATUS.md` somente com fatos verificados;
4. abra PR para `main` com resumo, arquivos-chave, testes feitos e pendências;
5. depois do merge, a próxima tarefa deve partir da `main` atualizada.

Não use memória de chat como fonte canônica quando ela divergir do GitHub. Em caso de conflito, prevalecem, nesta ordem:

1. instrução mais recente explícita de Marcos;
2. `AGENTS.md`;
3. `PROJECT_STATUS.md`;
4. `unity/VadroniaDemo/PROJECT_STATE.md`;
5. prompt operacional/documentos históricos.

## Branches antigas do Codex

Na auditoria de 05/10/2026, estas branches estavam atrás da `main` e 0 commits à frente:

- `codex/separate-unity-html`
- `codex/unity-grunwald-step1-transfer`
- `codex/unity-local-continuation`

Elas podem servir como histórico, mas não devem ser base para novo trabalho sem nova comparação.

## O que não fazer

- não editar diretamente a `main` para tarefas de desenvolvimento;
- não misturar Unity e HTML;
- não renumerar versões de uma plataforma usando a outra;
- não declarar teste, importação, compilação ou integração sem verificar;
- não gerar executável/pacote Windows sem pedido explícito;
- não substituir assets ou `.meta` sem backup e validação.
