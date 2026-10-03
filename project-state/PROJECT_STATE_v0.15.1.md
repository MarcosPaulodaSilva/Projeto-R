# PROJECT_STATE — Projeto R · Vadronia (v0.15.1)

## BASE

0.15.0 (Dungeons, arco de flechas 0.14.7, otimizações 0.14.8, introdução 0.14.5) + Castelo Morigan (0.15.1). Nada da 0.15 foi removido; as únicas edições em código existente foram na Crônica (checklist/aprovação/Ato V/painel/carta b2) e no `drawTree` (marco da Estrada Real).

## DONE (0.15.1)

- Estrada Real: marco ao norte da praça de Grünwald (abre ao ler a carta n1). Viagem = fade + 3h por trecho; Konrad espera.
- 3 cenas jogáveis: Praça do Castelo (fachada, fonte, Guilda, barracas, quadro de avisos, 6 NPCs), Salão do Trono, Sala dos Relatórios.
- Portões fecham ao anoitecer (canon da introdução); estalagem 8 coroas (dorme até 7h).
- Audiência com Beatrice (3 escolhas que importam), reações de Henry/Julian conforme `saga.stance`, Selo de Hóspede.
- Menus de Beatrice (Heinrich, Casas, ruínas, Nicasia), Henry, Julian, Kian (desenho da ponte → item + vínculo).
- Nicasia: 5 conversas (1 por visita), frase ensaiada NÃO dá ponto, autonomia dela valorizada; relatórios dinâmicos.
- Pedido só em conversa; se não pronto, ela lista o que falta; opção "aliado da Coroa" com final próprio. Mistérios permanecem abertos.
- Checklist em 2 fases (convite: bond 5/apr 3 · proposta: bond 12/apr 5 + audiência + 5 conversas). Save/load OK (posição de Grünwald dentro das cenas).
- Armas embainhadas nas cenas (Q/botão do meio bloqueados).

## TESTADO

Chromium headless, sem erros de console:
- viagem;
- audiência completa;
- 5 conversas por visita;
- pedido pronto/não pronto;
- aliado;
- noite + estalagem;
- ESC em cutscene;
- save/load em cena;
- render ~3,4 ms/quadro;
- fumaça de todos os NPCs e menus;
- regressão das Ruínas.

## NEXT

1. Playtest manual (tom dos diálogos, duração, balanceamento 12/5).
2. Konrad acompanhando ao castelo; duelo de treino com Julian.
3. Marcador do castelo no mapa (M) e música/ambiente das cenas.
4. Eisenbruck e Nebelheim (próxima região), Guilda de Vadronia com contratos reais.
5. Carta de Beatrice/Nicasia após a audiência (ponte entre visitas).

## KNOWN

- Tempo congela dentro das cenas (só avança nas viagens). Decisão de simplicidade.
- Caixa de diálogo cobre parte da cena (estilo `#dlg` herdado).

## DECISÕES

- Cenas assumem update/render/blocked/interact quando `CS` existe (mesmo padrão das Ruínas). Dentro da IIFE principal.
- Árvores da praça usam objetos estáveis por causa do cache de sprites da 0.14.8.
