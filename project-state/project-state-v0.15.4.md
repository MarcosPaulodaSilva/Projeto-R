# PROJECT_STATE — Projeto R (linha 0.15)
Arquivo atual: projeto-r-v0_15_4-vadronia.html (= SUA 0.15.2 + Pulso Arcano + correção do save no castelo).

## Mudou desde a 0.15.2
- 0.15.3 Pulso Arcano (tecla V): área raio 2,7, dano 16+INT*1,2, empurrão, 28 de fôlego, recarga 7 s, anel + barra no HUD. Overworld e Ruínas; bloqueado na corte (como o arco). Bloco independente antes do script da cinemática.
- 0.15.4 Save no castelo: saveData grava `scene:{id,x,y,from,back}` quando salvo dentro de uma cena; loadSave restaura a sala (ex.: Salão do Trono) na posição salva (cai no ponto inicial se estiver bloqueada). O save continua gravando a posição da vila como fallback; salvar na vila não tem `scene`. Mexeu só no wrapper saveData/loadSave do castelo (~linha 4499).
- Testes (Chromium): salvar no salão -> sair -> carregar volta ao salão; vaAudit() sem violações; sem erros/avisos; Q/V ignorados na corte.

## NEXT
0. Capital/Castelo Morigan jogável com cena de audiência (Nicasia/Beatrice).
1. Equipar habilidade por item; segunda arma (lança/adaga); botão Configurações no menu inicial.
2. Inimigos/tabardos Morigan nos guardas; Nicasia/Beatrice com vida própria; Eisenbruck.