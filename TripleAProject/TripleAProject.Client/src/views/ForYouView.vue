<script setup>
import NavBar from '../components/NavBar.vue';
import Footer from '../components/Footer.vue';
</script>

<template>
    <div id="page">
        <NavBar></NavBar>

        <div class="d-grid gap-2 m-4 p-2">
            <div class="leaf">
              <h1>New</h1>
                  <div class="row"> 
                    <div class="col-md-4 col-sm-6 col-xs-12 mt-4">
                        <div class="card item active">
                          <img 
                            class="card-img-top"
                            src="../assets/images/batman.png" 
                            alt="Batman"
                          >    
                        </div>
                      </div>
                      <div class="col-md-4 col-sm-6 col-xs-12 mt-4">
                        <div class="card">
                            <img
                                class="card-img-top"
                                id="card-fact-img"
                                src="../assets/images/beautyandthebeast.jpg" 
                                alt="Beautyandthebeast"
                            >   
                        </div> 
                      </div>
                      <div class="col-md-4 col-sm-6 col-xs-12 mt-4">
                        <div class="card">
                            <img
                                class="card-img-top"
                                id="card-fact-img"
                                src="../assets/images/blackpanther.jpg" 
                                alt="Blackpanther"
                            >   
                        </div> 
                      </div>  
                    </div>
              </div>
              <div class="leaf">
              <h1>All Time Favorite</h1>
                  <div class="row"> 
                    <div class="col-md-4 col-sm-6 col-xs-12 mt-4">
                        <div class="card item active">
                          <img 
                            class="card-img-top"
                            src="../assets/images/jaws.jpg" 
                            alt="Jaws"
                          >    
                        </div>
                      </div>
                      <div class="col-md-4 col-sm-6 col-xs-12 mt-4">
                        <div class="card">
                            <img
                                class="card-img-top"
                                id="card-fact-img"
                                src="../assets/images/spiderman.jpg" 
                                alt="Spiderman"
                            >   
                        </div> 
                      </div>
                      <div class="col-md-4 col-sm-6 col-xs-12 mt-4">
                        <div class="card">
                            <img
                                class="card-img-top"
                                id="card-fact-img"
                                src="../assets/images/starwars.png" 
                                alt="Starwars"
                            >   
                        </div> 
                      </div>  
                    </div>
              </div>
              <div class="leaf">
              <h1>Trending Now</h1>
                  <div class="row"> 
                    <div class="col-md-4 col-sm-6 col-xs-12 mt-4">
                        <div class="card item active">
                          <img 
                            class="card-img-top"
                            src="../assets/images/thehungergames.jpg" 
                            alt="TheHungerGames"
                          >    
                        </div>
                      </div>
                      <div class="col-md-4 col-sm-6 col-xs-12 mt-4">
                        <div class="card">
                            <img
                                class="card-img-top"
                                id="card-fact-img"
                                src="../assets/images/thelionking.jpg" 
                                alt="TheLionKing"
                            >   
                        </div> 
                      </div>
                      <div class="col-md-4 col-sm-6 col-xs-12 mt-4">
                        <div class="card">
                            <img
                                class="card-img-top"
                                id="card-fact-img"
                                src="../assets/images/titanic.jpg" 
                                alt="Titanic"
                            >   
                        </div> 
                      </div>  
                    </div>
                  </div>
            </div>
        </div>

    <Footer></Footer>
    

</template>



<style scoped>
#page {
    background: #4e4e4e
        url("data:image/svg+xml,%3Csvg width='52' height='26' viewBox='0 0 52 26' xmlns='http://www.w3.org/2000/svg'%3E%3Cg fill='none' fill-rule='evenodd'%3E%3Cg fill='%23c9b6e8' fill-opacity='0.86'%3E%3Cpath d='M10 10c0-2.21-1.79-4-4-4-3.314 0-6-2.686-6-6h2c0 2.21 1.79 4 4 4 3.314 0 6 2.686 6 6 0 2.21 1.79 4 4 4 3.314 0 6 2.686 6 6 0 2.21 1.79 4 4 4v2c-3.314 0-6-2.686-6-6 0-2.21-1.79-4-4-4-3.314 0-6-2.686-6-6zm25.464-1.95l8.486 8.486-1.414 1.414-8.486-8.486 1.414-1.414z' /%3E%3C/g%3E%3C/g%3E%3C/svg%3E")
        center fixed;
}

.leaf {
    border-radius: 70px 10px 70px 10px;
    background-color: #a18fbc;
    color: #fff;
    font-family: Poppins, sans-serif;
    margin-bottom: 3rem;
    padding: 3rem;  
    box-shadow:  14px 14px 28px #414141,
                -14px -14px 28px #5b5b5b;
}

.leaf-reverse {
    border-radius: 10px 70px 10px 70px;
    background-color: #a18fbc;
    color: #fff;
    font-family: Poppins, sans-serif;
    margin-bottom: 3rem;
    padding: 3rem;
    box-shadow:  14px 14px 28px #414141,
                -14px -14px 28px #5b5b5b;
}

.card {
 

  background-size: cover;
}

.card-image {
  max-width: 100%;
  max-height: 100%;
  display: block;
  margin: 0 auto;
  height: auto;
}

</style>