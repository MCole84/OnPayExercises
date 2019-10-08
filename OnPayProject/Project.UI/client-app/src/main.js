import Vue from 'vue';
import App from './App.vue';
import router from './router';
import store from './store';
import Tabs from 'vue-tabs-with-active-line';
Vue.config.productionTip = false;
new Vue({
    router,
    store,
    render: (h) => h(App),
}).$mount('#app');
//# sourceMappingURL=main.js.map