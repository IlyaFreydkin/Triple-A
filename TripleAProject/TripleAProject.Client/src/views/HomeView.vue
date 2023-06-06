<script setup>
import NavBar from '../components/NavBar.vue';
import Footer from '../components/Footer.vue';
import Banner from '../components/Banner.vue';
import Card from '../components/Card.vue';
</script>

<template>
    <div id="page">
        <NavBar></NavBar>
        <Banner></Banner>

    <div class="container">
        <div class="row">
            <div class="col-3">
                    <Card v-bind:image="card1Image">
                        
                    </Card>
            </div>
            <div class="col-3">
                    <Card v-bind:image="card2Image">
                       
                    </Card>
            </div>
            <div class="col-3">
                    <Card v-bind:image="card3Image">
                        
                    </Card>
            </div>
            <div class="col-3">
                    <Card v-bind:image="card4Image" >
                        
                    </Card>
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                    <Card v-bind:image="card5Image">
                     
                    </Card>
                    
            </div>
            <div class="col-3">
                    <Card v-bind:image="card3Image">
                    </Card>
            </div>
            <div class="col-3">
                    <Card v-bind:image="card2Image">
                     
                    </Card>
            </div>
            <div class="col-3">
                    <Card v-bind:image="card6Image">
                        
                    </Card>
                </div>
            </div>
        </div>

        <Footer></Footer>
    </div>
</template>


<script>
export default {

  data() {
    return {
        card1Image: "images/batman.png",
        card2Image: "images/beautyandthebeast.jpg",
        card3Image: "images/blackpanther.jpg",
        card4Image: "images/fightclub.png",
        card5Image: "images/jaws.jpg",
        card6Image: "images/spiderman.jpg"

    }
  },
  
}
</script>




<style scoped>

.container {
    margin-top: 70px;
    margin-bottom: 70px;
}



</style>