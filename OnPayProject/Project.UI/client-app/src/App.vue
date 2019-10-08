<template>
  <div>
    <h1 id="title">OnPay Exercise SPA</h1>
    <tabs
      :tabs="tabs"
      :currentTab="currentTab"
      :wrapper-class="'default-tabs'"
      :tab-class="'default-tabs__item'"
      :tab-active-class="'default-tabs__item_active'"
      :line-class="'default-tabs__active-line'"
      @onClick="handleClick"
    />
    <div class="content" id="content">
      <div v-if="currentTab === 'Login' && !this.loggedIn">
        <h1>Please Log in</h1>
        <div class="container">
          <label for="userName">User Name</label>
          <input type="text" placeholder="Enter User Name" id="userName" required />

          <label for="password">Password</label>
          <input type="password" placeholder="Enter password" id="password" required />
          <button
            v-on:click="handleLogin(document.getElementById('userName').value,document.getElementById('password').value)"
          >Log in</button>
        </div>
      </div>
      <div v-if="currentTab === 'Login' && this.loggedIn">
        <h1>Welcome</h1>
        <div class="dashboard"></div>
      </div>
      <div v-if="currentTab === 'Dashboard' && !this.loggedIn ">
        <h1>Please Log in to view your Dashboard</h1>
      </div>
      <div v-if="currentTab === 'Dashboard' && this.loggedIn ">
        <div class="container">
          <label>First Name </label>
          <input type="text" v-model='firstname' readonly />
          &nbsp;&nbsp;&nbsp;
          <label>Last Name </label>
          <input type="text" v-model='lastname' readonly /><br/>
          <label>Location &nbsp;&nbsp;&nbsp;</label>
          <input type="text" v-model='location' readonly /><br/>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import Tabs from "vue-tabs-with-active-line";

const TABS = [
  {
    title: "Login",
    value: "Login"
  },
  {
    title: "Dashboard",
    value: "Dashboard"
  }
];
export default {
  components: {
    Tabs
  },
  data: () => ({
    tabs: TABS,
    currentTab: "Login",
    loggedIn: true,
    userName: "",
    password: "",
    firstname: "Steven",
    lastname: "Roberts",
    location: "Jacksonville, FL"
  }),
  methods: {
    handleClick(newTab) {
      this.currentTab = newTab;
      var content = document.getElementById("content");
    },
    handleLogin: function(userName, password) {
      var user = document.getElementById("userName");
      var pass = document.getElementById("password");

      pass.value = "";
    }
  }
};
</script>

<style lang="scss">
.default-tabs {
  position: relative;
  margin: 0 auto;
  &__item {
    display: inline-block;
    margin: 0 5px;
    padding: 10px;
    padding-bottom: 8px;
    font-size: 16px;
    letter-spacing: 0.8px;
    color: gray;
    text-decoration: none;
    border: none;
    background-color: transparent;
    border-bottom: 2px solid transparent;
    cursor: pointer;
    transition: all 0.25s;
    &_active {
      color: black;
    }
    &:hover {
      border-bottom: 2px solid gray;
      color: black;
    }
    &:focus {
      outline: none;
      border-bottom: 2px solid gray;
      color: black;
    }
    &:first-child {
      margin-left: 0;
    }
    &:last-child {
      margin-right: 0;
    }
  }
  &__active-line {
    position: absolute;
    bottom: 0;
    left: 0;
    height: 2px;
    background-color: black;
    transition: transform 0.4s ease, width 0.4s ease;
  }
}
.content {
  margin-top: 30px;
  font-size: 20px;
}
#title {
  font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande",
    "Lucida Sans", Arial, sans-serif;
  font-style: italic;
}
body {
  background: lightblue;
}
.warning {
  color: red;
  font-style: italic;
  font-weight: bold;
}
</style>