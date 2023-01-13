<script setup>
import NavBar from '../components/NavBar.vue';
import Footer from '../components/Footer.vue';
</script>

<template>
    <div id="page">
        <NavBar></NavBar>

        <div class="d-grid gap-2 m-4 p-2">
            <div class="leaf">
                What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and
                typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever
                since the 1500s, when an unknown printer took a galley of type and scrambled it to
                make a type specimen book. It has survived not only five centuries, but also the
                leap into electronic typesetting, remaining essentially unchanged. It was
                popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum
                passages, and more recently with desktop publishing software like Aldus PageMaker
                including versions of Lorem Ipsum. Why do we use it? It is a long established fact
                that a reader will be distracted by the readable content of a page when looking at
                its layout. The point of using Lorem Ipsum is that it has a more-or-less normal
                distribution of letters, as opposed to using 'Content here, content here', making it
                look like readable English. Many desktop publishing packages and web page editors
                now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will
                uncover many web sites still in their infancy. Various versions have evolved over
                the years, sometimes by accident, sometimes on purpose (injected humour and the
                like).
            </div>
            <div class="leaf-reverse">
                What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and
                typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever
                since the 1500s, when an unknown printer took a galley of type and scrambled it to
                make a type specimen book. It has survived not only five centuries, but also the
                leap into electronic typesetting, remaining essentially unchanged. It was
                popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum
                passages, and more recently with desktop publishing software like Aldus PageMaker
                including versions of Lorem Ipsum. Why do we use it? It is a long established fact
                that a reader will be distracted by the readable content of a page when looking at
                its layout. The point of using Lorem Ipsum is that it has a more-or-less normal
                distribution of letters, as opposed to using 'Content here, content here', making it
                look like readable English. Many desktop publishing packages and web page editors
                now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will
                uncover many web sites still in their infancy. Various versions have evolved over
                the years, sometimes by accident, sometimes on purpose (injected humour and the
                like).
            </div>
            <div class="leaf">
                 What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and
                typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever
                since the 1500s, when an unknown printer took a galley of type and scrambled it to
                make a type specimen book. It has survived not only five centuries, but also the
                leap into electronic typesetting, remaining essentially unchanged. It was
                popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum
                passages, and more recently with desktop publishing software like Aldus PageMaker
                including versions of Lorem Ipsum. Why do we use it? It is a long established fact
                that a reader will be distracted by the readable content of a page when looking at
                its layout. The point of using Lorem Ipsum is that it has a more-or-less normal
                distribution of letters, as opposed to using 'Content here, content here', making it
                look like readable English. Many desktop publishing packages and web page editors
                now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will
                uncover many web sites still in their infancy. Various versions have evolved over
                the years, sometimes by accident, sometimes on purpose (injected humour and the
                like).
            </div>
            <div class="leaf-reverse">
                 What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and
                typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever
                since the 1500s, when an unknown printer took a galley of type and scrambled it to
                make a type specimen book. It has survived not only five centuries, but also the
                leap into electronic typesetting, remaining essentially unchanged. It was
                popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum
                passages, and more recently with desktop publishing software like Aldus PageMaker
                including versions of Lorem Ipsum. Why do we use it? It is a long established fact
                that a reader will be distracted by the readable content of a page when looking at
                its layout. The point of using Lorem Ipsum is that it has a more-or-less normal
                distribution of letters, as opposed to using 'Content here, content here', making it
                look like readable English. Many desktop publishing packages and web page editors
                now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will
                uncover many web sites still in their infancy. Various versions have evolved over
                the years, sometimes by accident, sometimes on purpose (injected humour and the
                like).
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
</style>