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
                    <Card>
                        <img :src="card1Image" alt="Card 1">
                    </Card>
                </div>
                <div class="col-3">
                    <Card>
                        <img :src="card2Image" alt="Card 2">
                    </Card>
                </div>
                <div class="col-3">
                    <Card>
                        <img :src="card3Image" alt="Card 3">
                    </Card>
                </div>
                <div class="col-3">
                    <Card>
                        <img :src="card4Image" alt="Card 4">
                    </Card>
                </div>
            </div>
            <div class="row">
                <div class="col-3">
                    <Card>
                        <img :src="card5Image" alt="Card 5">
                    </Card>
                </div>
                <div class="col-3">
                    <Card>
                        <img :src="card6Image" alt="Card 6">
                    </Card>
                </div>
                <div class="col-3">
                    <Card>
                        <img :src="card7Image" alt="Card 7">
                    </Card>
                </div>
                <div class="col-3">
                    <Card>
                        <img :src="card8Image" alt="Card 8">
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
            card1Image: '../images/card1.jpg',
            card2Image: '../images/card2.jpg',
            card3Image: '../images/card3.jpg',
            card4Image: '../images/card4.jpg',
            card5Image: '../images/card5.jpg',
            card6Image: '../images/card6.jpg',
            card7Image: '../images/card7.jpg',
            card8Image: '../images/card8.jpg',
        };
    },
};
</script>




<style scoped>

.container {
    margin-top: 70px;
    margin-bottom: 70px;
}



</style>