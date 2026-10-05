# PROJECT_STATE — demo Unity / Grünwald

## CURRENT
Unity 6.6, C#, Built-in, top-down ortogonal. Continuação da demo existente; não altera a numeração das builds HTML históricas. Pedido atual: melhorar passos do Player/Conrad e iniciar a cidade.

## IMPLEMENTADO
- 16 poses novas por personagem (quatro direções, quatro poses); repouso separado, âncoras de cabeça e pés medidas.
- Passos sincronizados à distância real; colisões com subpassos, deslizamento lateral e limites do mapa.
- Praça, ruas, gramado e 13 objetos de cenário: casas, estalagem, guilda, ferraria, poço, mercado e árvores.
- Câmera acompanha Player; Conrad patrulha a praça e pausa; ordenação vertical.
- Menu de verificações no Editor; testes de regras de movimento independentes de Unity.

## TESTADO
10 verificações C# executadas com .NET 8, incluindo 10.000 movimentos aleatórios, bloqueio em paredes, parada de passos, quatro direções, fase por distância e patrulha (>20 voltas). Sintaxe C# verificada por Roslyn com/sem ENABLE_INPUT_SYSTEM. Texturas RGBA, presença de todos os recortes e limites conferidos.

## NÃO VALIDADO / LIMITAÇÕES
Sem execução do Editor, Play Mode ou build Windows: ferramenta Unity CLI instalada, mas nenhum Editor/login disponível e cliente de licença inacessível. Ainda avaliar a fluidez visual e API compatibility no Unity 6.6. Poses são geradas; revisão artística fina pode ser necessária. Cena criada via EditorSceneManager; cenário aparece ao entrar em Play. Prédios sem interiores; atores não bloqueiam um ao outro nesta demo.

## DECISÕES
Pedido recente de Unity/top-down prevalece sobre HTML/isometria do Master Prompt. Aplicadas as diretrizes de continuar a base, separar responsabilidades, priorizar movimento/colisão, testar casos extremos e manter escopo pequeno. Mantidos WASD/setas da demo existente. Nenhum sistema de combate ou progressão adicionado. Sem online, dependências pagas ou pacotes externos.

## NEXT
Abrir na Unity 6.6, executar Vadronia > Verificar demo e teste manual de caminhada/colisão/ordenação. Ajustar ritmos e pivôs após observação em Play; depois decidir a primeira interação da praça antes de ampliar o mapa.
