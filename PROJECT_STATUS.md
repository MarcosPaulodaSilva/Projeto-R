# PROJECT_STATUS — painel operacional canônico

> Leia este arquivo depois de `AGENTS.md` antes de começar qualquer tarefa no Projeto R.

## Regra principal

- A branch `main` é a fonte canônica de progresso integrado.
- **Unity é a única implementação do projeto.**
- Não use uma branch antiga como base sem comparar com `main`.
- Toda tarefa que alterar comportamento, arte integrada, documentação operacional ou estado validado deve atualizar este arquivo no mesmo PR.

## Estado observado

- Repositório: `MarcosPaulodaSilva/Projeto-R`
- Branch canônica: `main`
- Projeto do Editor: `unity/VadroniaDemo`
- Engine: Unity 6.6 / 6000.6.0f1
- Direção atual: 2D top-down ortogonal, C#, Built-in pipeline
- Estado técnico detalhado: `unity/VadroniaDemo/PROJECT_STATE.md`
- Histórico de validação/local: `unity/project-state/unity-local-2026-10-04.md`
- Prompt operacional: `unity/docs/prompts/super-master-prompt-projeto-r-unity.md`
- Bíblia de design/arquitetura: `unity/docs/design/biblia-projeto-r-pre-producao-unity-pos-auditoria.txt`
- Lore canônico: `docs/lore/biblia-historia-mundo-lore-projeto-r.txt`

## Último estado validado

Em 05/10/2026, a documentação registra como implementados: terreno atualizado, personagens com pernas animadas independentemente, ambientação, câmera suave, HUD em UI Toolkit, corrida/fôlego, esquiva, interação com Conrad, coleta de três ervas, recompensa única de 25 moedas e save local.

Validações registradas: 20 verificações de lógica + 11 verificações em Play aprovadas.

Limites registrados: prédios ainda externos, um NPC, sem combate e sem interiores.

## Foco atual

Priorizar a evolução da base Unity validada. Antes de expandir escopo, preservar funcionamento existente, arquivos `.meta`, GUIDs, saves, arte aprovada e assets já integrados.

## Fila operacional

Use esta ordem salvo instrução mais recente de Marcos:

1. continuar a atualização visual/animação já autorizada;
2. manter caminhada com passos baixos e alternância real das duas pernas;
3. evoluir mecânicas sobre a base Unity validada;
4. validar no Editor e registrar somente o que foi realmente testado;
5. atualizar este painel e `unity/VadroniaDemo/PROJECT_STATE.md` quando o estado do jogo mudar.

## Handoff entre agentes

Ao terminar uma tarefa:

1. trabalhe em branch nova criada a partir de `main`;
2. faça commits pequenos e descritivos;
3. atualize `PROJECT_STATUS.md` somente com fatos verificados;
4. abra PR para `main` com resumo, arquivos-chave, testes e pendências;
5. depois do merge, a próxima tarefa deve partir da `main` atualizada.

Não use memória de chat como fonte canônica quando ela divergir do GitHub. Em caso de conflito, prevalecem, nesta ordem:

1. instrução mais recente explícita de Marcos;
2. `AGENTS.md`;
3. `PROJECT_STATUS.md`;
4. `unity/VadroniaDemo/PROJECT_STATE.md`;
5. Super Master, Bíblia e documentos históricos.

## Branches antigas

Na auditoria de 05/10/2026, as branches antigas do Codex verificadas estavam 0 commits à frente da `main` e apenas atrás. Elas podem servir como histórico técnico, mas não devem ser base para novo trabalho sem nova comparação.

## O que não fazer

- não editar diretamente a `main` para tarefas de desenvolvimento;
- não recriar implementações aposentadas;
- não declarar teste, importação, compilação ou integração sem verificar;
- não gerar executável/pacote Windows sem pedido explícito;
- não substituir assets ou `.meta` sem backup e validação.
