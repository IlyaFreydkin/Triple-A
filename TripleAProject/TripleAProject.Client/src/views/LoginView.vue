<script setup>
import NavBar from '../components/NavBar.vue'
import axios from 'axios'

</script>

<template>
    <div class="login">
        <NavBar></NavBar>

        <div class="wrapper">
            <div class="logo">
                <img src="../images/logo.jpg" alt="">
            </div>
            <div class="text-center mt-4 name">
                Triple A
            </div>
            <form class="p-3 mt-3">
                <div class="form-field d-flex align-items-center">
                    <span class="far fa-user"></span>
                    <input v-model="model.name" type="text" name="userName" id="userName" placeholder="Username">
                </div>
                <div class="form-field d-flex align-items-center">
                    <span class="fas fa-key"></span>
                    <input v-model="model.password" type="password" name="password" id="pwd" placeholder="Password">
                </div>
                <button type="button" class="btn mt-3" v-on:click="sendLoginData">Login</button>
            </form>
            <div class="text-center fs-6">
                or <br> <router-link to="signup"><a href="#">Sign up</a></router-link>
            </div>
        </div>


    </div>

</template>

<script>
export default {
    data() {
        return {
            model: {
                name: "",
                password: "",
            },
        };
    },
    methods: {
        deleteToken() {
            delete axios.defaults.headers.common["Authorization"];
            this.$store.commit("authenticate", null);
        },
        async sendLoginData() {
            console.log("Sending login data")
            try {
                await axios.post("https://localhost:5001/api/user/login", {
                    name: this.model.name,
                    password: this.model.password,
                });
                console.log("Login successful");
                alert("Eingeloggt mit " + this.model.name)
            } catch (e) {

                alert("Login failed");

            }
        },
    },
    computed: {
        authenticated() {
            return this.$store.state.user.isLoggedIn;
        },
        username() {
            return this.$store.state.user.username;
        },
    },
};
</script>

<style scoped>
/* Importing fonts from Google */


/* Reseting */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: 'Poppins', sans-serif;
}

body {
    background: #ecf0f3;
}

.wrapper {
    max-width: 350px;
    min-height: 500px;
    margin: 80px auto;
    padding: 40px 30px 30px 30px;
    background-color: #ecf0f3;
    border-radius: 15px;
    box-shadow: 13px 13px 20px #cbced1, -13px -13px 20px #fff;
}

.logo {
    width: 80px;
    margin: auto;
}

.logo img {
    width: 100%;
    height: 80px;
    object-fit: cover;
    border-radius: 50%;
    box-shadow: 0px 0px 3px #5f5f5f,
        0px 0px 0px 5px #ecf0f3,
        8px 8px 15px #a7aaa7,
        -8px -8px 15px #fff;
}

.wrapper .name {
    font-weight: 600;
    font-size: 1.4rem;
    letter-spacing: 1.3px;
    padding-left: 10px;
    color: #555;
}

.wrapper .form-field input {
    width: 100%;
    display: block;
    border: none;
    outline: none;
    background: none;
    font-size: 1.2rem;
    color: #666;
    padding: 10px 15px 10px 10px;
    /* border: 1px solid red; */
}

.wrapper .form-field {
    padding-left: 10px;
    margin-bottom: 20px;
    border-radius: 20px;
    box-shadow: inset 8px 8px 8px #cbced1, inset -8px -8px 8px #fff;
}

.wrapper .form-field .fas {
    color: #555;
}

.wrapper .btn {
    box-shadow: none;
    width: 100%;
    height: 40px;
    background-image: linear-gradient(to bottom right, #4B279B, #DF99D8);
    color: #fff;
    border-radius: 25px;
    box-shadow: 3px 3px 3px #b1b1b1,
        -3px -3px 3px #fff;
    letter-spacing: 1.3px;
}

.wrapper .btn:hover {
    background-color: #039BE5;
}

.wrapper a {
    text-decoration: none;
    font-size: 0.8rem;
    color: #03A9F4;
}

.wrapper a:hover {
    color: #039BE5;
}

@media(max-width: 380px) {
    .wrapper {
        margin: 30px 20px;
        padding: 40px 15px 15px 15px;
    }
}
</style>