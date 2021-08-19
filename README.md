<h1 align="center">
  <br>
  Gilded Rose
</h1>

<p align="center">
  <img alt="Linguagem mais usada Javascript" src="https://img.shields.io/github/languages/top/pedro-lisboa/Gilded-Rose?style=flat">
  <img alt="Objetivo: estudo" src="https://img.shields.io/badge/purpose-study-lightgrey?style=flat">
</p>

<h1>Descrição do sistema</h1>

<li>Todos os itens (classe Item) possuem uma propriedade chamada SellIn que informa o número de dias que temos para vende-lo</li>
<li>Todos os itens possuem uma propriedade chamada quality que informa o quão valioso é o item.</li>
<li>No final do dia, o sistema decrementa os valores das propriedades SellIn e quality de cada um dos itens do estoque através do método updateQuality.</li>

<li>Quando a data de venda do item tiver passado, a qualidade (quality) do item diminui duas vezes mais rapido.</li>
<li>A qualidade (quality) do item não pode ser negativa</li>
<li>O "Queijo Brie envelhecido" (Aged Brie), aumenta sua qualidade (quality) em 1 unidade a medida que envelhece.</li>
<li>A qualidade (quality) de um item não pode ser maior que 50.</li>
<li>O item "Sulfuras" (Sulfuras), por ser um item lendário, não precisa ter uma data de venda (SellIn) e sua qualidade (quality) não precisa ser diminuida.</li>
<li>O item "Entrada para os Bastidores" (Backstage Passes), assim como o "Queijo Brie envelhecido", aumenta sua qualidade (quality) a medida que o dia da venda (SellIn) se aproxima;</li>
    <ul>
<li>A qualidade (quality) aumenta em 2 unidades quando a data de venda (SellIn) é igual ou menor que 10.</li>
<li>A qualidade (quality) aumenta em 3 unidades quando a data de venda (SellIn) é igual ou menor que 5.</li>
<li>A qualidade (quality) do item vai direto à 0 quando a data de venda (SellIn) tiver passado.</li>
    </ul>
<li>Os itens "Conjurados" (Conjured) diminuem a qualidade (quality) duas vezes mais rápido que os outros itens.
Sinta-se livre para fazer qualquer alteração no método updateQuality e adicionar código novo contanto que tudo continue funcionando perfeitamente. Entretanto, não altere o código da classe Item ou da propriedade Items na classe GildedRose pois elas pertencem ao Goblin que irá te matar com um golpe pois ele não acredita na cultura de código compartilhado.

<h1>Nota Final</h1>
Para esclarecer: Um item não pode ter uma qualidade (quality) maior que 50, entretanto as "Sulfuras" por serem um item lendário vão ter uma qualidade imutavel de 80.
