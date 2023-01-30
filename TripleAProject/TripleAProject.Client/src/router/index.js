import { createRouter, createWebHistory } from 'vue-router'
import store from '../store.js'
import HomeView from '../views/HomeView.vue'
import ForYouView from '../views/ForYouView.vue'
import LoginView from '../views/LoginView.vue'
import SignUpView from '../views/SignUpView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/login',
      name: 'login',
      component: LoginView
    },
    {
      path: '/signup',
      name: 'signup',
      component: SignUpView
    },
    {
      path: '/foryou',
      name: 'foryou',
      component: ForYouView
    }
    
  ]
})

router.beforeEach((to, from, next) => {
  const authenticated = store.state.user.isLoggedIn;
  if (to.meta.authorize && !authenticated) {
    next("/");
    return;
  }
  next();
  return;
});
export default router
