<template>
    
    <div class="banner-area">
        <h1>Triple A</h1>
        <h6>Wo Filme schauen leichter wird</h6>
    </div>
</template>


<style scoped>

*{
    margin: 0;
    padding: 0;
}

 h1, h6{
    font-family: 'Poppins', sans-serif;
    text-align: center;
    color: rgb(109, 19, 100);
}

.banner-area{
    background-image: linear-gradient(to bottom right,#4B279B,#DF99D8);
    background-image: url(../images/carousel-1.jpg);
    background-size: cover;
    background-position: center center;
    height: 100vh;
    top: 100px;
    width: 100%;
    position:fixed;

}

.banner-area::after{
    content: '';
    position: absolute;
    top: 0;
    left: 0;
    display: block;
    width: 100%;
    height: 100%;
    background: #6e6d80;
    opacity: .7;
    z-index: -1;
}


.banner-area h1, h6{
    padding-top: 8%;
    font-size: 80px;
    color: white;
}


</style>