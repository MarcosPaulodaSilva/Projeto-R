# Auditoria detalhada — Projeto R · Vadronia v0.15.1

## Resumo executivo

A 0.15.1 é uma expansão coerente da 0.15.0. O Castelo Morigan conversa com a Crônica, reputação, Grandes Casas, ruínas, noites defendidas, cartas, Nicasia, Beatrice e sucessão. O conteúdo novo respeita bem o cânone geral: Beatrice permanece forte apesar do luto; Henry e Julian não são tratados como vilões; Nicasia mantém autonomia; Heinrich e a civilização antiga continuam com mistérios abertos.

O Castelo está funcional como protótipo narrativo, mas a build geral ainda carrega dívida técnica da 0.15.0 e a rota política chega ao epílogo antes de dramatizar plenamente a resolução sucessória.

## Pontos fortes

- Estrutura do Castelo relativamente isolada do loop principal, reduzindo risco de regressão.
- Viagem para a capital salva posição/estado de Grünwald e restaura na volta.
- Audiência com Beatrice altera aprovação e postura política.
- Henry, Julian e Kian preservam personalidades distintas.
- Nicasia recompensa respostas coerentes com sua autonomia, em vez de uma "frase correta".
- O mistério de Heinrich e das ruínas não é resolvido artificialmente.
- O desenho da ponte por Kian conecta a capital a Grünwald de forma simples e eficaz.

## Bugs e problemas técnicos priorizados

| Gravidade | Problema | Estado |
|---|---|---|
| Alta | Morte na dungeon aplica penalidade duplicada | Presente |
| Média | Personagem pode começar com PV abaixo do máximo derivado | Presente |
| Média | Level up pode não encher PV até o novo máximo | Presente |
| Média/Alta | Konrad é removido da dungeon em vez de usar DOWN/revive | Incompleto |
| Média | Save/load no Castelo pode servir como retorno gratuito a Grünwald | Novo efeito sistêmico |
| Média | "Um dia de marcha" versus viagem mecânica de 3h | Incoerência |
| Média | Dormir depois da meia-noite pode avançar um dia a mais | Presente |
| Baixa/Média | DevTools `goRoom()` continua inseguro em certas salas | Presente |
| Baixa | Identidade de versão continua misturada | Presente |

### Penalidade dupla na dungeon

A morte da dungeon aplica perda própria de XP/coroas e depois chama o respawn do overworld, que aplica nova perda. Esse deve ser o primeiro conserto técnico.

### PV inicial e level up

O máximo derivado pode aumentar depois de o HP ter sido preenchido, deixando o jogador abaixo do máximo imediatamente após criação ou level up.

### Konrad em dungeon

A entrada na dungeon desativa o companion. Isso entra em conflito com a regra atual de companion incapacitado com janela de resgate.

### Descanso

A estalagem define diretamente 07h e incrementa o dia, o que pode pular um dia quando o jogador já está depois da meia-noite.

### Estrada Real

O texto diz "um dia de marcha", mas a viagem soma 3 horas. Recomenda-se alinhar texto e regra.

### Save dentro do Castelo

Salvar em cena serializa a posição de Grünwald. Ao recarregar, o jogador retorna à vila sem necessariamente pagar o custo de retorno, abrindo um pequeno exploit temporal.

## Principal lacuna narrativa: sucessão

A Crônica pode marcar "Legitimidade: sucessão resolvida de forma coerente" quando Casa e stance são compatíveis, mas não há ainda uma cena ou evento que realmente resolva Henry × Julian. O epílogo descreve funções administrativas/militares, porém não dramatiza qual acordo sucessório foi formalizado.

Recomendação: transformar a stance em posição do jogador e criar um evento político curto entre Beatrice, Henry, Julian e representantes das Casas. Isso fecha a legitimidade sem vilanizar nenhum irmão.

## Grandes Casas

O apoio das Casas ainda funciona mais como checklist do que como política vivida. Recomenda-se ao menos uma interação ou missão representativa por Casa. Não é necessário criar três campanhas extensas.

## Nicasia

As cinco conversas funcionam bem como estrutura, mas a relação ainda fica presa ao ciclo "viaja → escritório → conversa → volta". O próximo avanço ideal seria Nicasia visitar Grünwald e interagir com o mundo que ela conhece apenas por relatórios e cartas.

## Pedido e casamento

Atualmente pedido aceito e casamento/epílogo ficam muito próximos. Recomenda-se separar:
1. pedido aceito;
2. consequência política/preparação;
3. resolução sucessória;
4. casamento/epílogo.

## Aliado da Coroa

A rota alternativa é boa e reforça a autonomia dos personagens. Falta apenas decidir se ela é uma conclusão definitiva ou uma posição reversível.

## Castelo e mundo vivo

Congelar o tempo nas cenas é aceitável nesta fase. Antes de expandir muito a capital, priorizar:
- ambiente sonoro;
- marcador no mapa;
- pequenas variações dia/noite;
- cartas e reações pós-audiência;
- um ou dois acontecimentos adicionais.

## Documentação e versão

Há identidade de versão misturada entre referências antigas 0.14.8/0.25 e a build atual 0.15.1. Recomenda-se limpar essas referências para evitar merges e instruções erradas.

## Próximos passos recomendados

### P0 — estabilidade
- corrigir penalidade dupla da dungeon;
- corrigir PV inicial;
- corrigir heal de level up;
- corrigir descanso após meia-noite;
- alinhar identidade de versão.

### P1 — sistemas prometidos
- Konrad dentro da dungeon com DOWN/revive;
- revisar `goRoom`/DevTools;
- revisar save/load temporal do Castelo;
- regressão de save em cutscene, audiência e Nicasia.

### P2 — arco político
- evento de resolução Henry × Julian;
- tornar apoio das Casas mais diegético;
- separar pedido de casamento;
- carta pós-audiência.

### P3 — aprofundar Castelo
- Konrad acompanhando até a capital;
- treino com Julian;
- marcador no mapa;
- música/ambiente;
- Nicasia visitando Grünwald.

Depois disso, Eisenbruck e Nebelheim podem ser iniciadas com menos dívida acumulada.

## Conclusão

A 0.15.1 avançou bastante o Projeto R e o Castelo Morigan está entre os módulos narrativos mais coerentes da build atual. Ainda não é recomendável tratar o vertical slice como fechado: morte, PV, companion/dungeon, save temporal e sucessão devem ser estabilizados antes da expansão territorial.
