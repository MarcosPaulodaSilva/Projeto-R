# Arquitetura técnica — Projeto R / Unity

Este é o mapa curto para localizar código e decidir onde novos arquivos devem entrar.

## Runtime

`unity/VadroniaDemo/Assets/Scripts/`

| Módulo | Responsabilidade | Arquivos atuais |
|---|---|---|
| `Core/` | Regras e estado sem dependência de cena | `AdventureState`, `MovementCore` |
| `Player/` | Input, movimento e câmera do jogador | `ExplorerMotor`, `AdventureCamera` |
| `World/` | Mundo, layout e interações da vila | `TownLayout`, `TownWorld`, `VillageAtmosphere`, `VillageInteraction` |
| `UI/` | HUD e apresentação de interface | `AdventureHud` |
| `Visual/` | Renderização de personagens, atlas e biblioteca visual | `CharacterView`, `VisualLibrary`, layouts de atlas |
| `Bootstrap/` | Composição/inicialização da demo | `VadroniaDemo` |

Todos continuam no namespace `Vadronia`. A reorganização é física; não altera APIs nem GUIDs dos scripts existentes.

## Editor e validação

`Assets/Editor/Checks/` contém verificações automatizadas.
`Assets/Editor/Setup/` contém preparação/configuração da demo.

`Tests/Regression.csproj` executa verificações de lógica fora do Editor e referencia apenas os arquivos necessários.

## Direção de dependências

Preferir este fluxo:

```text
Bootstrap
 ├─ Player ─┬─ Core
 │          ├─ Visual
 │          └─ World
 ├─ World ──┬─ Core
 │          └─ Visual
 └─ UI ─────── Core

Editor/Checks -> Runtime
Editor/Setup  -> Runtime
Runtime      -X-> Editor
```

Evite dependência circular. `Core` deve continuar o mais independente possível.

## Onde colocar novos sistemas

Quando os sistemas forem implementados, crie módulos irmãos somente quando houver código real: `Combat/`, `NPC/`, `Companions/`, `Inventory/`, `Persistence/`, `Dungeons/`. Não crie pastas vazias por antecipação.

## Decisões de otimização

- Não adicionar `.asmdef` agora: o projeto possui poucos scripts e o ganho de compilação seria pequeno frente à complexidade extra.
- Adicionar assemblies somente quando o tempo de compilação ou o número de módulos justificar fronteiras reais.
- Não mover assets para Addressables sem necessidade concreta de streaming/memória.
- Manter imagens de referência fora do projeto Unity quando não precisam ser importadas pelo Editor.
- Preservar `.meta` e GUIDs em qualquer movimentação de arquivo Unity.

## Arquivos técnicos da raiz

- `.gitignore`: evita cache/build/IDE.
- `.gitattributes`: normaliza texto e marca binários.
- `.editorconfig`: padroniza edição básica.
- `PROJECT_STATUS.md`: estado e próximo passo.
- `AGENTS.md`: regras de operação.
