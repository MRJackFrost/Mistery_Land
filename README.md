<!-- README: Mistery Land -->
<h1 align="center">Mistery Land</h1>

<p align="center">
  <em>Jogo mobile feito em Unity para testar mecânicas de movimentação, boas práticas de Clean Code e um sistema de batalhas em turno.</em>
</p>

<p align="center">
  <!-- Badges (opcionais). Troque 'main' pela sua branch padrão, se necessário. -->
  <a href="https://unity.com/"><img alt="Unity" src="https://img.shields.io/badge/Engine-Unity-black?logo=unity"></a>
  <img alt="Platform" src="https://img.shields.io/badge/Platform-Android%20%7C%20iOS-blue">
  <img alt="Status" src="https://img.shields.io/badge/Status-Em%20desenvolvimento-yellow">
</p>

<hr/>

<h2 id="sobre">🧭 Sobre o Projeto</h2>
<p>
  <strong>Mistery Land</strong> é um projeto de estudo focado em:
</p>
<ul>
  <li><strong>Movimentação</strong> do personagem (toque/virtual joystick ou equivalente).</li>
  <li><strong>Clean Code</strong> e organização de pastas, scripts e cenas.</li>
  <li><strong>Batalhas em turno</strong> simples: você controla um pequeno dinossauro e enfrenta monstros espalhados pelo cenário.</li>
</ul>
<p>
  O objetivo é manter o código legível, testável e escalável, servindo de base para features futuras.
</p>

<h2 id="sumario">📚 Sumário</h2>
<ol>
  <li><a href="#sobre">Sobre o Projeto</a></li>
  <li><a href="#gameplay">Gameplay & Mecânicas</a></li>
  <li><a href="#controles">Controles</a></li>
  <li><a href="#arquitetura">Arquitetura & Padrões</a></li>
  <li><a href="#rodar">Como Abrir, Rodar e Buildar</a></li>
  <li><a href="#licenca">Licença</a></li>
</ol>

<h2 id="gameplay">🎮 Gameplay & Mecânicas</h2>
<ul>
  <li><strong>Exploração:</strong> cenários com NPCs/monstros para iniciar combates.</li>
  <li><strong>Combate em turno:</strong> sequência de turnos (jogador &rarr; inimigos), com ações como <em>Atacar</em>, <em>Defender</em> e <em>Habilidade</em>.</li>
  <li><strong>Prototipagem rápida:</strong> foco em loop básico (entrar em combate &rarr; resolver &rarr; voltar ao mundo).</li>
</ul>

<h3>Recursos já implementados (exemplo)</h3>
<ul>
  <li>Movimentação do dinossauro pelo cenário.</li>
  <li>Trigger de batalha ao encostar em inimigos.</li>
  <li>Fluxo de turnos e execução de ações básicas.</li>
</ul>

<h3>Recursos planejados</h3>
<ul>
  <li>HUD/menus polidos para mobile.</li>
  <li>Balance e variedade de inimigos/skills.</li>
  <li>Feedbacks visuais/sonoros e FX.</li>
</ul>

<h2 id="controles">🕹️ Controles</h2>
<ul>
  <li><strong>Toque/Joystick virtual:</strong> mover o personagem.</li>
  <li><strong>Botões de ação (combate):</strong> Atacar / Defender / Habilidade / Item.</li>
</ul>
<p><em>Observação:</em> Ajuste conforme o esquema real do seu projeto. Se usar novo Input System, inclua os mapas de ação correspondentes.</p>

<h2 id="arquitetura">🧱 Arquitetura & Padrões</h2>
<ul>
  <li><strong>Clean Code:</strong> nomes descritivos, classes coesas, responsabilidades claras.</li>
  <li><strong>SOLID:</strong> especialmente <em>Single Responsibility</em> e <em>Open/Closed</em>.</li>
  <li><strong>Eventos</strong> (C# events/UnityEvent) para desacoplar UI e lógica.</li>
</ul>

<h2 id="rodar">🚀 Como Abrir, Rodar e Buildar</h2>
<ol>
  <li>Clone o repositório:
    <pre><code>git clone https://github.com/MRJackFrost/Mistery_Land.git</code></pre>
  </li>
  <li>Abra o projeto no <strong>Unity</strong> (versão igual ou superior à usada no projeto).</li>
  <li>Carregue a cena principal em <code>Assets/_Project/Scenes/</code> e pressione <strong>Play</strong>.</li>
  <li>Para build mobile:
    <ul>
      <li><strong>Android:</strong> <em>File &gt; Build Settings &gt; Android</em>, configure SDK/NDK, e gere o APK/AAB.</li>
      <li><strong>iOS:</strong> <em>File &gt; Build Settings &gt; iOS</em>, gere o Xcode project e faça o deploy.</li>
    </ul>
  </li>
</ol>


<h2 id="licenca">📄 Licença</h2>
<p>
  Defina a licença do projeto (ex.: MIT). Se usar MIT, adicione o arquivo <code>LICENSE</code> e referencie aqui.
</p>

<hr/>

<p align="center">
  Feito com ❤️ para estudar Unity, Clean Code e batalhas em turno.<br/>
  <small>© <!-- Seu nome/ano aqui --> </small>
</p>
