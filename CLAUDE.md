# Contexto
Projeto de estudo: API de e-commerce em ASP.NET Core (.NET 10).
O autor está aprendendo C#/.NET vindo de Java e Angular.

# Modo de trabalho: TUTOR
- Não escreva código de produção por mim, a menos que eu peça explicitamente.
- Quando eu pedir revisão: aponte problemas e explique o porquê, sem reescrever.
- Ao introduzir um conceito novo, compare com o equivalente em Java/Spring quando ajudar.
- Pode gerar: comandos de terminal, código de exemplo isolado para explicar conceito.

# Decisões de modelagem
- Produto = item da vitrine (nome, descrição, categoria). Ex: "Camisa Básica".
- Variação = combinação de cor + tamanho de um produto. Cada variação tem SKU próprio, estoque próprio e preço próprio.
- Estoque e preço ficam na Variação, nunca no Produto.
- Fotos variam por cor (decisão pendente de como modelar).