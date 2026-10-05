# PROJECT_STATE — Projeto R (linha 0.16)
Arquivo atual: projeto-r-v0_16_1-vadronia.html (= 0.16.0 + varredura geral de bugs; só correções e pequenos ajustes).

## 0.16.1 — o que foi corrigido
BUGS DE JOGO
- Quests: entregar "A Estrada" resetava Ferro/Pedra Antiga/Vozes para "disponível" (perdia progresso e permitia refazer quest concluída). Agora só destrava se estiver "locked".
- Abas dos painéis (Mochila/Personagem/Missões/Ajustes): clicar numa aba lançava `openPanel is not defined` e não fazia nada (só Crônica funcionava). Agora usa os atalhos I/K/J/C/M.
- Arco (Q) e Pulso Arcano (V) disparavam com mochila/painel aberto e gastavam fôlego (100→58). Causa: `openPanel`, `DG` e `floatText` eram locais da IIFE principal e invisíveis aos scripts externos (guardas `typeof` nunca acionavam; números de dano de arco/pulso nunca apareciam; arco não sabia que estava em dungeon). Agora expostos em `window`.
- Cenas do castelo: `scPlace` procura ponto livre se o destino cair em parede (jogador nunca fica preso).
INCOERÊNCIAS / LORE
- Narração da introdução citava "inverno" (Master: não existem estações) → "o frio".
- Item "Coifa da Cripta" e "Lâmina do Marco" (restos da Cripta descartada) → "Coifa de Pedra-Muda" e "Lâmina Reforjada".
- Versões: título (0.15.2/0.14.4), DevTools ("0.14 CLOUD + EXTRAS 0.25") e build (0.16.0) unificados em 0.16.1.
UI / FEATURES
- Aviso "✉ carta nova — C" não cobre mais painéis abertos; barra do Pulso Arcano não sobrepõe a dica do rodapé.
- Mapa (Ajustes > Mapa) marca a Estrada Real / VADRONIA.
- DevTools: botões do castelo (Estrada Real, Praça, Salão, Relatórios, Guilda, Liberar convite); snapshot agora inclui quests e Crônica; botão "ferir civil" não gera mais falso positivo na auditoria. `window.vaQuests` exposto para testes.

## TESTADO (Chromium, entradas reais; sem erros de console no pacote final)
Abertura→menu→jogo pelo caminho real; fuzz de entradas (vila dia/noite, Ruínas); fuzz de 110 transições (Ruínas↔vila↔castelo↔morte↔pausa↔save/load) com invariantes; todos os botões do DevTools; movimento/colisão/ataque/combo/esquiva/bloqueio/aparo/arco/pulso/tônico/morte; diálogos e lojas dos 5 NPCs; cadeia completa de quests (inclusive ervas e pedra físicas); economia (sem ouro, equipado/quest não vende); save/load pela pausa e CONTINUAR após recarregar; Reiniciar tudo; noite completa (160 s); Ruínas small/medium/large até o boss e saída + morte; castelo (praça, Guilda, salão, audiência, escritório, todos os NPCs); clima; redimensionamento; 59-60 fps a 1080p, memória estável (10 MB); auditoria interna sem violações.

## NEXT (próxima versão — Master Prompt)
1. PLAYTEST HUMANO: ritmo do início, dificuldade do boss, metas da Crônica (bond 12 / aprovação 5), duração das Ruínas (Master §75: 10–20 / 20–35 / 35–60 min).
2. Escala em 720p/768p: hoje só inteira (2×, margens grandes). Opção em Ajustes: "Inteira / Ajustada (0,5×)".
3. Konrad (e depois outros companions, máx. 3) acompanhando ao castelo e às Ruínas, com DOWN/resgate (Master §42).
4. Capital além da praça: mercado/Guilda com contratos reais, companions da Guilda, tabardos Morigan nos guardas.
5. Equipamento: habilidade/arma equipável, 2ª arma (lança/adaga), `DEV.progression.giveSet` equipar de fato; Ruínas "large" sem recompensa única nova (considerar uma por tamanho).
6. Eisenbruck e Nebelheim (próxima região); transição por fade já existe nas cenas.
7. Tempo congelado dentro das cenas do castelo (decisão de simplicidade): avaliar passar tempo ou "esperar".
8. Falas por tabela (rumor) e textos de loja/itens ainda sem revisão linha a linha.
9. Música/ambiência (áudio) e polimento de partículas; testes automatizados dos fluxos críticos (hoje scripts em /tmp, não versionados).

## NÃO REVISADO / CONHECIDO
- Textos de itens/loja, falas por tabela e algumas falas de Konrad/Gerda/Brunna/Elsbeth/Otto só por amostra.
- Quests concluídas via `vaSaga.dev('all')` mostram 0/N nos objetivos (artefato do atalho, não do jogo).
- Caixa de diálogo cobre parte da cena nas cenas do castelo.