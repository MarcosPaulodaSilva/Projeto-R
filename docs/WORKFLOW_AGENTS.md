# Workflow de colaboração — humano + ChatGPT/Codex

Este documento define como múltiplos agentes devem trabalhar no mesmo Projeto R sem perder progresso.

## Fonte canônica

O GitHub é o ponto de encontro entre os agentes. Não existe pressuposto de memória compartilhada entre conversas ou ambientes; decisões e estado devem ficar registrados no repositório.

Arquivos que todo agente deve ler, nesta ordem:

1. `/AGENTS.md`
2. `/PROJECT_STATUS.md`
3. `/unity/VadroniaDemo/PROJECT_STATE.md`
4. documentação específica da tarefa

## Uma tarefa = uma branch

Formato recomendado:

- `codex/<tarefa>`
- `chatgpt/<tarefa>`
- `fix/<tarefa>`
- `docs/<tarefa>`

A branch sempre nasce da `main` atualizada. Evite continuar branches antigas apenas porque já têm nome parecido.

## Antes de editar

- compare a branch com `main`;
- confirme que não existe PR aberto alterando os mesmos arquivos;
- leia o estado atual;
- identifique quais arquivos serão tocados;
- preserve `.meta`, GUIDs, saves e a estrutura do projeto Unity.

## Durante a tarefa

- prefira mudanças pequenas e verificáveis;
- não combine reorganização massiva com mudança de gameplay no mesmo PR;
- não duplique documentação canônica;
- mantenha links para a fonte canônica em vez de copiar grandes blocos;
- se uma decisão mudar, atualize o arquivo canônico correspondente.

## Ao finalizar

O PR deve dizer claramente:

- objetivo;
- o que mudou;
- arquivos principais;
- como foi validado;
- o que não foi validado;
- riscos/pendências;
- próximo passo recomendado.

Se o estado jogável mudou, atualize também:

- `/PROJECT_STATUS.md`
- `/unity/VadroniaDemo/PROJECT_STATE.md`

## Regra para evitar conflito entre dois agentes

Se dois agentes trabalharem em paralelo, cada um deve atuar em arquivos ou subsistemas diferentes quando possível. Se ambos precisarem alterar o mesmo arquivo central, o segundo deve partir do estado integrado mais recente ou reconciliar conscientemente as mudanças antes do merge.

## Documentação canônica

- Coordenação atual: `/PROJECT_STATUS.md`
- Regras para agentes: `/AGENTS.md`
- Estado do jogo: `/unity/VadroniaDemo/PROJECT_STATE.md`
- Super Master: `/unity/docs/prompts/super-master-prompt-projeto-r-unity.md`
- Bíblia de design: `/unity/docs/design/biblia-projeto-r-pre-producao-unity-pos-auditoria.txt`
- Lore: `/docs/lore/`
- Referências visuais: `/docs/references/`
- Áudio e vídeos: `/assets/`

Não transforme documentos históricos em fonte de estado atual quando houver documento canônico mais recente.
