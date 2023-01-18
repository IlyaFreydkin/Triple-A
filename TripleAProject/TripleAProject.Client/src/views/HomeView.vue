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
                <Card></Card>
            </div>
            <div class="col-3">
                <Card></Card>
            </div>
            <div class="col-3">
                <Card></Card>
            </div>
            <div class="col-3">
                <Card></Card>
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <Card></Card>
            </div>
            <div class="col-3">
                <Card></Card>
            </div>
            <div class="col-3">
                <Card></Card>
            </div>
            <div class="col-3">
                <Card></Card>
            </div>
        </div>


      
      
    </div>

    
    </div>

    <Footer></Footer>
</template>



<style scoped>





</style>