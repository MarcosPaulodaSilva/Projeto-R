# Base compartilhada — Projeto R

Este arquivo existe dentro de cada implementação para evitar que decisões importantes do Projeto R fiquem presas a uma única plataforma.

## Autoridade e separação

- **Unity** é a implementação atualmente em desenvolvimento.
- **HTML** é a linha histórica de navegador, atualmente preservada até a v0.16.1.
- Lore, direção narrativa, referências visuais e contexto de áudio são compartilhados entre as duas implementações.
- Decisões técnicas específicas de HTML ou Unity não devem ser copiadas automaticamente para a outra plataforma como se fossem equivalentes.

## Regras compartilhadas que não podem se perder

- O Projeto R é um RPG de ação 2D medieval-fantástico.
- O mundo deve parecer vivo e independente do protagonista; o jogador não começa como um “escolhido”.
- Existem três reinos principais: **Vadronia, Migriard e Vitehria**.
- Vadronia inclui a capital Vadronia, Eisenbruck, Grünwald e Nebelheim.
- A Casa Morigan governa Vadronia.
- A civilização antiga de Vadronia permanece deliberadamente misteriosa: sua língua e história não devem ser explicadas por completo.
- O ciclo de dia/noite deve afetar atmosfera, iluminação, rotinas e perigo.
- Não existem estações anuais sistêmicas nem envelhecimento automático do elenco.
- Vilas e cidades devem transmitir vida cotidiana, comércio, rotinas e segurança relativa; estradas, ruínas e dungeons carregam maior perigo.
- Companions, progressão, equipamentos, dungeons, reputação/relações e consequências de morte fazem parte da visão maior do projeto, mesmo quando uma implementação ainda não possui todos esses sistemas.
- Referências de arte devem preservar a identidade de pixel art e não devem ser redesenhadas silenciosamente como substituição de uma fonte aprovada.

## Fontes compartilhadas canônicas

- Lore: `/docs/lore/biblia-historia-mundo-lore-projeto-r.txt`
- Referências visuais: `/docs/references/sprites/`
- Contexto e manifesto de música: `/assets/music/`
- Vídeos de referência: `/assets/videos/`

As cópias desta pasta são conveniências para trabalho local em cada plataforma. Em caso de divergência, a fonte compartilhada da raiz é a referência principal.
