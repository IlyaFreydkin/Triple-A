<script setup>
import LogoBanner from './components/LogoBanner.vue'
</script>

<template>
    <!-- Template needs to have one root element -->
    <div>
        <div id="header">
            <h1>Triple A</h1>
        </div>
        <div id="main">
            <LogoBanner></LogoBanner>
        </div>
    </div>
</template>

<style>
html,
body {
display: flex;
align-items: flex-start;
justify-content: left;
}

</style>


