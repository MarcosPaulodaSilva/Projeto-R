# PROJECT_STATE — Projeto R (linha 0.15)
Arquivo atual: projeto-r-v0_15_8-vadronia.html (= 0.15.6 + Guilda jogável + muralha revisada).

## 0.15.8 (revisão de textos vs Master Prompt)
- Revisados: intro, Beatrice, cartas de Nicasia/Guilda/Beatrice, falas de Nicasia, rumores, guardas, quadro. Canon OK (idades, Heinrich 57/dois anos, 18 anos, Casas, civilização antiga sem explicação, protagonista não escolhido).
- Corrigido: Kian misturava 'o senhor'/'você'; carta de Nicasia dizia que Kian pediu a ela para desenhar a ponte (o contrário do diálogo de Kian); fala de guarda da vila refinada.
- NÃO revisado: textos de inventário/loja/itens, falas de Konrad/Gerda/Brunna/Elsbeth/Otto e missões da vila (só amostra), tabelas ambientais restantes.

## 0.15.7 (anterior)
- GUILDA: a sede na praça de Vadronia agora tem porta (tile 'Y' em 7,14, face leste) e interior "Salão de Registros" (cena 'guild', 13x11): balcão, quadro de avisos, Mestra Ilse (movida da praça para dentro). Saída pelo piso 'E' do fundo. Save/load restaura a sala (SCN genérico).
- Quadro da Guilda: texto honesto (sem contratos ainda). Guarda do castelo agora diz "A Guilda fica na praça, à esquerda. Pode entrar."
- Muralha do castelo: topo menos claro/chapado (era lido como uma "linha" separando castelo e cidade). Não confirmado com o usuário: se a linha ainda aparecer, pedir captura de tela.
- Hooks de teste novos em projetoR: scEnter(), scGoto(id,x,y), CS.
- Varredura (Chromium): 600 seeds de dungeon válidas, run completa com boss, 61 fps, 10 MB, sem erros de console.
## NÃO FEITO / NEXT
- Revisão linha a linha de TODO o código e das falas geradas por rumor(n) (não revisadas desde 0.15.5).
- Contratos/companions da Guilda (Master Prompt), capital jogável além da praça, Configurações no menu.