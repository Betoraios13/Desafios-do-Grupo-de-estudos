# 📚 Quem Sou Eu?

Nesse jogo, o usuário deve descobrir quem ele é (animal, objeto, personagem etc.) a partir de uma série de dicas que são reveladas uma a uma. Quanto menos dicas usar e mais rápido for, maior é a pontuação.

---

## ✨ Funcionalidades

1. Apresente um **Menu Inicial** com opções:
    - Jogar
    - Ajuda
    - Ver leaderboard
    - Sair

2. Ao escolher **Jogar**:
    - Sorteie um elemento (não se repete na mesma sessão).
    - Exiba a categoria (ex.: 🐾 Animais).

3. Revele até **10 dicas**, uma de cada vez:
    - O usuário pode tentar adivinhar a qualquer momento.
    - Ao errar, ganha a próxima dica.
    - Se digitar **“desistir”**, pontuação zera e volta ao menu.
    
4. Calcule a pontuação:
    - **100 pontos** para acerto sem dicas.
    - **–10 pontos** por cada dica usada.
    - **–1 ponto** por minuto gasto desde a primeira dica até o acerto.

5. Caso o usuário use todas as dicas, ele receberá uma mensagem de derrota.

6. Caso o usuário vença, se a pontuação estiver entre as 10 melhores, peça o nome para incluir no **leaderboard**.

7. O **leaderboard** guarda as 10 maiores pontuações em arquivo separado.

---

## 🚀 Tecnologias Utilizadas

- "C# (.NET 8.0)"
- "Linq (Language Integreted Query)"

---

### 📥 Executar

```Terminal
    "dotnet run"