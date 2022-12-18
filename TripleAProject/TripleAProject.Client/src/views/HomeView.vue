<script setup>
import NavBar from '../components/NavBar.vue'

</script>

<template>
        <NavBar></NavBar>

        
      <img  src="../images/carousel-1.jpg" alt="Image">
                    <div class="carousel-caption">
                        <div class="container">
                            <div class="row justify-content-center">
                                <div class="col-md-7">
                                    <h1 class="display-4 text-light mb-5 animated slideInDown">Welcome to the most comforting streaming Plattform</h1>
                                    <a href="" class="btn btn-primary py-sm-3 px-sm-5">Start now</a>
                                </div>
                            </div>
                        </div>
                    </div>
</template>

<style scoped>
          


.carousel-caption {
    top:0;
    left: 0;
    right: 0;
    bottom: 0;
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
    
    background: rgba(51, 21, 62, 0.512);
    z-index: 1;
}

img {
    width: 100%;
    height: 100%;
   
}

.btn {
    font-weight: 500;
    
        background-color: rgba(112, 51, 135, 0.816);
        border-block-color: #4B279B;
        border-radius: 40px;
}




</style>