# Vadrônia — Grünwald, demo Unity 6.6

Continuação do projeto de movimento: Player e Conrad, caminhada em quatro direções e primeira área externa de Grünwald. Unity/C#, 2D top-down ortogonal, sem isometria.

## Abrir

1. Extraia o ZIP em uma nova pasta (preserve sua versão anterior).
2. No Unity Hub, **Add > Add project from disk**, selecione `VadroniaDemo` e abra com **Unity 6.6 / 6000.6.x**. Aceite atualizar o patch caso o Hub pergunte.
3. Aguarde importação e compilação. A cena é criada automaticamente na primeira abertura; use **Vadronia > Abrir demo** se necessário.
4. Pressione **Play** e clique na aba Game. **WASD ou setas** movem o jogador. Vá para o norte para explorar a praça e as construções.

O cenário é construído ao entrar em Play. Fora de Play, a cena contém seu inicializador. Selecione esse objeto e ative Gizmos para visualizar as áreas de colisão.

Para atualizar uma cópia já existente, faça backup antes e copie a pasta `Assets` completa desta versão. Os GUIDs anteriores foram preservados; a referência ao atlas antigo permanece válida. Não é preciso substituir sua cena nem as configurações pessoais do Editor.

## O que mudou

- Novas folhas de caminhada para os dois personagens: poses de contato e passagem, passadas abertas, joelhos elevados e balanço de braços. Os pontos de apoio foram medidos por quadro.
- Os passos avançam pela **distância realmente percorrida**, com ciclo de 1,2 unidades, em vez de um relógio fixo. Empurrar uma parede não mantém a animação andando. Em repouso, usam poses neutras da folha anterior, mantendo a orientação.
- Grünwald inicial: praça de pedra, ruas de terra, gramado, casas, estalagem, fachada da guilda, ferraria, poço, banca e árvores.
- Colisão pelo ponto dos pés, com raio de 0,22; telhados e copas não bloqueiam o caminho. Resolução em pequenos passos evita atravessar obstáculos em quadros demorados.
- Conrad patrulha quatro pontos da praça com pausas; câmera ortográfica acompanha o Player; desenho ordenado pela posição vertical.

As construções são exteriores cenográficos. Não há interiores, combate, outros NPCs, quests, inventário ou salvamento nesta etapa.

## Verificação

**Vadronia > Verificar demo** executa 10 verificações de lógica, confere presença/filtro das texturas e exige pipeline Built-in. Depois valide em Play:

- Caminhe e pare nas quatro direções; observe contato/passage das pernas e braços.
- Pressione uma casa/poço e deslize ao longo das bordas; não deve atravessar nem continuar dando passos parado.
- Contorne uma árvore pela frente e por trás; a ordem de desenho deve mudar.
- Observe uma volta completa de Conrad; ele deve parar nas esquinas e retomar.
- Redimensione a Game view e confira a câmera. Confira o Console sem erros.

Os mesmos testes de lógica podem rodar sem Unity, com .NET 8: `dotnet run --project Tests/Regression.csproj`. Não usam pacotes NuGet externos.

**Resultado nesta entrega:** 10 verificações passaram, incluindo 10.000 deslocamentos aleatórios e mais de 20 voltas de patrulha. Código C# de Assets analisado sintaticamente nas duas configurações de input. Atlases e recortes verificados. **Compilação com as APIs Unity, Play Mode, aparência em movimento e build Windows não foram executados.** O ambiente de criação não tem Editor instalado, login Unity ou cliente de licença funcional. Esses testes de lógica não substituem a validação no Editor.

## Executável Windows

Instale Windows Build Support pelo Unity Hub, então use **Vadronia > Gerar executável Windows**. Distribua a pasta inteira gerada. Não há `.exe` pré-compilado neste ZIP.

## Organização

- `VadroniaDemo.cs`: inicialização, input, patrulha e câmera.
- `MovementCore.cs`: colisão e ciclo de passos, independentes do motor e testados.
- `CharacterView.cs`: sprites, repouso e direção.
- `TownLayout.cs`: construções, áreas sólidas e rota de Conrad.
- `TownWorld.cs`: terreno e renderização do cenário.
- `Assets/Resources/Vadronia/`: duas folhas de caminhada e sprites da vila.
- `Assets/Art/characters.png`: arte anterior usada para repouso.
- `Tools/measure_atlases.py`: análise dos limites/âncoras; requer Pillow e não altera pixels.
- `PROJECT_STATE.md`: decisões, testes e próximos passos.

Pipeline Built-in; filtro Point, sem compressão, mipmaps ou antialiasing. A câmera tem posição alinhada ao pixel do terreno, mas não há promessa de pixel-perfect estrito em toda resolução/escala dos personagens.

Arte de movimento adaptada das referências do repositório: protagonista nº 05 e Conrad nº 07. Os atlases novos são gerados e ainda merecem revisão visual em movimento no Editor. Os originais do repositório permanecem intactos.
