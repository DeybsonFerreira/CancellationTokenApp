# 🧠 CancellationToken na prática (.NET MVC)

Este projeto tem como objetivo **demonstrar, de forma prática e visual**, como funciona o `CancellationToken` no .NET, comparando um processamento **com cancelamento cooperativo** versus um processamento **sem cancelamento**.

A ideia não é criar um sistema produtivo, mas **aprender observando o comportamento real do backend**.

---

## 🎯 Objetivo do projeto

- Entender **o que é** um `CancellationToken`
- Ver **como ele funciona na prática**
- Comparar:
  - Processamento **com** `CancellationToken`
  - Processamento **sem** `CancellationToken`
- Observar o impacto real no backend quando:
  - O request é cancelado
  - A página é atualizada
  - O cliente “desiste” da operação

---

## 🧩 O que é CancellationToken?

`CancellationToken` é um **mecanismo de cancelamento cooperativo**.

Ele **não mata threads**, **não interrompe código à força** e **não cancela nada sozinho**.

👉 Ele apenas **sinaliza** que uma operação **deveria parar**,  
e cabe ao código **respeitar esse sinal**.

Em outras palavras:

> “Alguém pediu para cancelar.  
> Se você estiver preparado, pare agora.”

---

## ▶️ Como testar (passo a passo)

1. **Execute o projeto**
2. Abra o navegador
3. Abra o **Console da aplicação** (terminal / output)
4. Clique em um dos botões
5. **Durante o processamento:**
   - Atualize a página (F5)
   - Ou feche a aba

---

## 🧠 Por que isso é importante?

Em aplicações reais, **não usar CancellationToken** pode causar:

- Consumo desnecessário de CPU
- Uso excessivo de banco de dados
- Threads ocupadas sem necessidade
- Custos maiores em cloud
- Baixa escalabilidade

Usar `CancellationToken` significa:

> **Respeitar o ciclo de vida da requisição e economizar recursos.**

---

## 🧠 Conceito-chave aprendido

> CancellationToken **não cancela tarefas**  
> Ele permite que **tarefas se cancelem corretamente**

Cancelamento é:
- Cooperativo
- Explícito
- Controlado
- Seguro

---

## 🛠️ Tecnologias utilizadas

- ASP.NET MVC / ASP.NET Core
- C#
- JavaScript (Fetch API)
- Bootstrap (UI)
- CancellationToken (.NET)

---

🚀🚀🚀🚀 Enjoy!
