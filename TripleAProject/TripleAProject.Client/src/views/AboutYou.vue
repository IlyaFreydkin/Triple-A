<template>
  <div id="aboutYou">
    <div id="page">
      <NavBar></NavBar>
      <Banner></Banner>
    </div>

    <div class="content">
    

      <h1>Über mich</h1>
      <p>
        Ich bin ein leidenschaftlicher Filmeschauer und liebe es, in die Welt
        der Filme einzutauchen. Seit meiner Kindheit faszinieren mich
        Geschichten auf der großen Leinwand und ich habe eine tiefe Liebe für
        verschiedene Filmgenres entwickelt.
      </p>

      <p>
        Auf meiner Webseite teile ich meine Erfahrungen, Meinungen und
        Empfehlungen zu Filmen. Ich schreibe gerne Rezensionen, gebe Filmtipps
        und diskutiere gerne über die neuesten Entwicklungen in der Filmwelt.
      </p>

      <p>
        Wenn du auch ein Filmfan bist, bist du hier genau richtig! Tauche ein in
        meine Webseite und lass uns gemeinsam die Welt des Films erkunden.
      </p>

      <h1>Wer bin ich</h1>
      <p>Ich bin ein Leidenschaftlicher Programmierer der HTL SPengergasse</p>
      <p>
        Ich bin der Meinung, dass jede Person Zugang zu einer kostenlosen und
        guten Streaming-Webseite haben sollte. Filme und Serien sind eine
        großartige Möglichkeit, sich zu unterhalten, Geschichten zu entdecken
        und unterschiedliche Kulturen kennenzulernen. Durch den Zugang zu einer
        breiten Auswahl an Filmen können Menschen ihre Leidenschaft für das Kino
        ausleben, unabhängig von ihrem Hintergrund oder ihrem finanziellen
        Status.
      </p>
    </div>

    <Footer></Footer>
  </div>
</template>

<script>
import NavBar from "../components/NavBar.vue";
import Banner from "../components/Banner.vue";
import Footer from "../components/Footer.vue";

export default {
  components: {
    NavBar,
    Footer,
  },
};
</script>

<style>
/* Hier kannst du die Farben anpassen */
#aboutYou {
  background-color: #f2f2f2;
}

/* Füge hier deine gewünschten Stile für den Text hinzu */
.content {
  
    background-image: url(../images/hinterg.jpg) ;
    background-size: cover;
    background-position: center;
    height: 500px;
    width: 100%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;
    color: white;
    font-family: 'Roboto', sans-serif;
    font-weight: 100;
    font-size: 20px;
    letter-spacing: 2px;
    text-transform: uppercase;
    padding: 0 20px;
    box-sizing: border-box;


  
}

h1 {
  font-size: 28px;
  color: #333;
}

p {
  font-size: 18px;
  color: white;
  margin-bottom: 10px;
}
</style>
