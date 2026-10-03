# PROJECT_STATE — Projeto R (base 0.14; 0.25 complementa)
Arquivo atual: projeto-r-v0_14_6-vadronia.html (build.py = HTML 0.14 original + patches + assets/va_visual.js + va_saga.js + va_ai.js + va_chars.js).

## DONE
- 0.14.1: visual Vadronia (fundo panorama, chão, árvores, casas de ardósia, lampiões Morigan, título).
- 0.14.2: ESC = pausa (salvar/carregar/reiniciar), DevTools em F3, portal restaurado, ordem de desenho por caixas, sombras do sol, props reais (cercas colidem sem isolar ninguém).
- 0.14.3:
  - Título: CONTINUAR (mostra dia/hora/nível) e NOVO JOGO (2 cliques, apaga save). Antes o jogo carregava o save sozinho e parecia "começar no dia 3".
  - Arco principal "Caminho da Coroa" + Crônica (tecla C): 5 atos, cartas com escolhas (Nicasia, Guilda, Beatrice), 3 Grandes Casas com exigências e posição na sucessão, lista de legitimidade, audiência no Castelo Morigan, pedido de casamento e epílogo. Persistência no save.
  - Final NÃO é medidor: exige vínculo ≥7, aprovação de Beatrice ≥4, apoio de Casa, reputação ≥10, Ruínas vencidas, 4 noites defendidas sem civis feridos, 2 elites derrotados e sucessão coerente (Silberhain só aceita processo neutro; Falkenberg: Julian/neutro; Eichenwald: Henry/neutro).
  - Testes: story.py (jogo inteiro até o casamento), title.py, func.py, sweep.py, smoke.py, invariants/stress Node. Todos passam.
- 0.14.4 (mecânica): percepção dos inimigos melee da estrada (bandido, lobo): visão em cone de 150° com linha de visão (árvores/casas bloqueiam, rio não), raio de visão 75% do aggro, percepção periférica a 2,2 tiles, audição (ataque 7, esquiva 5, bloqueio 4, correr 3,2 tiles; 60% sem linha de visão), última posição conhecida, estados INVESTIGATE -> SEARCH -> RETURN, marcador "?" sobre o inimigo. Aparada perfeita abre RIPOSTA (1,6 s): próximo golpe causa 2,4x e mais knockback, inimigo pisca em vermelho. Testes: tests/ai_test.js (12 cenários).
- 0.14.5: cercas viram paredes finas (segmento, não tile inteiro: não dá mais para atravessar) e postes de lampião bloqueiam só a base (antes bloqueavam o tile da rua inteiro). Teste: tests/fence2.js. Bônus: Elsbeth agora alcança o trabalho (só gerda.door segue fora da grade).
- 0.14.6: personagens redesenhados (human()): botas, pernas sombreadas, tronco com luz e sombra, cinto com fivela, colarinho, braços balançando com mãos, cabelo com franja e laterais. Só visual.
- 0.14.9: a correção de cercas/postes (que eu havia feito na 0.14.5) aplicada sobre a SUA 0.14.8 (que tem arco Q, otimizações e abertura cinematográfica, feitos fora desta sessão). Só o bloco vaSolidProps foi trocado e `blocked` ganhou colisores finos; nada mais mudou. Testado em Chromium real com teclas: cerca bloqueia dos dois lados, dá para contornar pelas pontas, postes só bloqueiam a base.
- ATENÇÃO: o build.py desta pasta gera a linha 0.14.x minha (sem arco/otimizações/abertura). A linha oficial agora é o HTML 0.15.2 (derivado do 0.15.1 enviado); trabalhe nele, não no build.py.
- 0.14.10 (atualização curta, sobre a sua 0.14.9): tiro do arco (Q) faz barulho de 8 tiles e atrai inimigos (integra arco + audição); log de IA limitado a 200 entradas (antes crescia sem fim); dt nunca negativo; auditoria de invariantes do Master (seção 77) a cada 3 s: PV/fôlego/posição finitos, ouro e inventário >= 0, hora válida, civil abrigado nunca ferido à noite, morto não ataca, IDs únicos, quest concluída não ativa. Violações vão para console.warn e window.__vaViolations; window.vaAudit() roda sob demanda. Teste: tests/t10.py.
- 0.15.2 (sobre a SUA 0.15.1, que já tem Praça, Salão do Trono e Sala dos Relatórios do Castelo Morigan, família Morigan e Nicasia): só um bloco novo, human() redesenhado no estilo Vadronia (botas, luz e sombra no tronco, mãos, colarinho, cabelo em camadas, nariz). Mesma assinatura e mesmo retorno, então tabardos, elmos, coroa, lanças e vestidos do castelo continuam alinhados. Testado em Chromium real: vila, salão, praça, escritório, pausa, F3, Crônica, colisões, auditoria e arco, sem erro no console.
- Achado (não corrigido): salvar dentro do castelo grava a posição da vila (8,5; 13,5) e o carregar volta para a vila, sem fade. Funciona, mas o jogador perde o lugar onde estava no castelo.
## CURRENT
- Etapa 2 do visual: personagens/NPCs/inimigos no estilo das sheets; props de vilarejo (barracas, estábulo, moinho, capela).
## NEXT
0. Capital/Castelo Morigan jogável (cena de audiência com Nicasia e Beatrice) usando o mesmo mecanismo de instância das Ruínas (genDungeon/loadRoom/exitToOverworld em game.js ~1503-1990).
1. Inimigos (lobo, bandido, sombra, guardião) e tabardos Morigan nos guardas.
2. Nicasia/Beatrice com vida própria (aparecem na Capital quando ela existir); Capital e Castelo Morigan jogáveis.
3. Percepção/investigação de inimigos, riposte, mais asserts.
4. Mais cartas/eventos reagindo a conduta (promessas quebradas, civis feridos).
5. Eisenbruck.
## KNOWN BUGS
- elsbeth.work e gerda.door fora da grade alcançável (já era assim na 0.14).
- Arco usa cartas (a Capital ainda não existe); a audiência é um painel, não uma cena.
- Texto das cartas é fixo; ainda não reage a promessas quebradas.
## IMPORTANT DECISIONS
- Base 0.14, versões 0.14.x. DevTools F3, Pausa ESC, Crônica C.
- História principal: casar com Nicasia só por mérito e legitimidade (canon do Contexto Mestre), sem medidor único. Atalho de teste: vaSaga.dev('all') no console.