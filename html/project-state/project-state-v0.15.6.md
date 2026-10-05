# PROJECT_STATE — Projeto R (linha 0.15)
Arquivo atual: projeto-r-v0_15_6-vadronia.html (= SUA 0.15.2 + Pulso Arcano + save no castelo + revisão de textos + botão Controles).

## 0.15.6
- Menu inicial: botão "Controles" (lista de teclas, fecha com clique; Enter continua iniciando). Texto de versão do título corrigido (estava 0.14.8). Varredura geral: painéis, F1/F3, redimensionar janela (600x900 a 1920x1080), memória estável (10 MB), 60 fps, auditoria sem violações, sem erros.

## Mudou desde a 0.15.4 (0.15.5 — área de textos)
- Falas reescritas por clareza (sentido mantido, canon intacto): Otto ("Uma estrada não vive só de pedra: vive de gente..."), fala dupla negação removida; Henry (comida/"quem recebe primeiro", "Grãos, tributos, guarnições..."), Beatrice ("é com ela que preciso conversar antes de responder"), Nicasia (carta: "Respondi que sim, pelo que os relatórios contam"; "Mãe, posso mostrar a Sala dos Relatórios ao nosso hóspede?"; "Governarem juntos..."; "É uma opinião honesta, mas X merece o mesmo respeito"), Crônica Ato I ("Quando terminar, seu nome começará a circular além do vilarejo.").
- Interface de texto: dicas (hint), "[T] Falar" e barra do Pulso somem enquanto houver painel, pausa, DevTools ou diálogo aberto (antes vazavam por trás da caixa). Caixa de diálogo com altura máxima e rolagem (textos longos não saem da tela). Avisos (toast) ficam o tempo proporcional ao tamanho (2,2 a 6,5 s) e quebram linha. Mudanças isoladas: <style id="va-text-fix"> e um script curto antes da cinemática.
- Convenção mantida: NPCs formais dizem "o senhor"; narração e Konrad/aldeões dizem "você".
## Histórico (0.15.3/0.15.4)
- Pulso Arcano (V): raio 2,7, 16+INT*1,2, 28 FO, recarga 7 s; bloqueado na corte. Save dentro do castelo grava d.scene e o carregar restaura a sala.
## Testes (Chromium): menu, auditoria vaAudit() sem violações, save/load no salão, pulso/arco, ruínas, sem erros no console.
## NEXT
0. Capital/Castelo jogável com audiência; 1. habilidade/arma equipável, segunda arma, botão Configurações no menu (Controles já existe); 2. tabardos Morigan nos guardas, Eisenbruck.
## NÃO REVISADO
- Falas geradas a partir de tabelas de rumores/ambientais ("rumor(n)") e textos em runtime com variáveis; textos do sistema (inventário/loja) só foram checados visualmente.