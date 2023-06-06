<template>
    <div class="card">

   <div class="card-body">
       <img v-bind:src="image"   class="card-image"> 
   </div>
</div>



</template>

<script>
export default {
  props: {
    image: String,
  },

  data() {
    return {
    }
  },
  
}
</script>



<style scoped>

.card {
  box-sizing: border-box;
  width: 190px;
  height: 254px;
  margin: 10px;

  background: rgba(217, 217, 217, 0.58);
  border: 1px solid white;
  box-shadow: 12px 17px 51px rgba(0, 0, 0, 0.22);
  backdrop-filter: blur(6px);
  border-radius: 17px;
  text-align: center;
  cursor: pointer;
  transition: all 0.5s;
  display: flex;
  align-items: center;
  justify-content: center;
  user-select: none;
  font-weight: bolder;
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


.card:hover {
  border: 1px solid black;
  transform: scale(1.05);
}

.card:active {
  transform: scale(0.95) rotateZ(1.7deg);
}
</style>