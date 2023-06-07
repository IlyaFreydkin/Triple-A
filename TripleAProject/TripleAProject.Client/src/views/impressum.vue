<template>
    <div id="impressum">
    <div id="page">
      <NavBar></NavBar>
      <Banner></Banner>
    </div >

<body>
    

    <div class="content">
    <h1>Impressum</h1>

      <table>
        <tr>
          <td><h2>ANgeben:</h2></td>
        </tr>
        <tr>
          <td>Ahmed Moahmed </td>
        </tr>
        <tr>
          <td>Spengergasse</td>
        </tr>
        <tr>
          <td>Wien</td>
        </tr>

        <tr>
          <td><h2>Kontakt:</h2></td>
        </tr>
        <tr>
          <td>Telefon: 01234-567890</td>
        </tr>
        <tr>
          <td>E-Mail: spengergasse.at</td>
        </tr>

        <tr>
          <td><h2>Verantwortlich für diesen  Inhalt :</h2></td>
        </tr>
        <tr>
          <td>Ahmed Moahmed </td>
        </tr>
        <tr>
          <td>Sepnegergasse </td>
        </tr>
        <tr>
          <td>Wien</td>
        </tr>

        <tr>
          <td><h2>Haftungsausschluss:</h2></td>
        </tr>
        <tr>
          <td>Haftung für Inhalte</td>
        </tr>
        <tr>
          <td>Haftung für Links</td>
        </tr>
        <tr>
          <td>Urheberrecht</td>
        </tr>

      
        
      </table>
    </div>
    </body>
  </div>
 <Footer></Footer> 
 
  <footer></footer>
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
  font-size: 24px;
  font-weight: bold;
}

h2 {
  font-size: 20px;
  font-weight: bold;
  margin-top: 20px;
}

p {
  font-size: 18px;
  margin-bottom: 10px;
}
td{

    font-size: 12px;
}
</style>