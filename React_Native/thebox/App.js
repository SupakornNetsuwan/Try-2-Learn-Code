/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow strict-local
 */

import React from 'react';
import {
  SafeAreaView,
  StyleSheet,
  ScrollView,
  View,
  Text,
  StatusBar,
  Button,
  TextInput,
} from 'react-native';

const App: () => React$Node = () => {
  return (
    <View style={styles.container}>
    <View style={styles.main}>
      <View style={styles.lands}>
        <View style={styles.loginbtn}>
          <View style={styles.rect}>
            <Text style={styles.login}>LOGIN</Text>
          </View>
        </View>
        <View style={styles.regbtn}>
          <View style={styles.regbg}>
            <Text style={styles.signUp}>SIGN UP</Text>
          </View>
        </View>
      </View>
      <View style={styles.hr1}></View>
      <TextInput
        placeholder="EMAIL"
        placeholderTextColor="rgba(230, 230, 230,1)"
        keyboardAppearance="default"
        style={styles.emailinput}
      ></TextInput>
      <TextInput
        placeholder="PASSWORD"
        placeholderTextColor="rgba(230, 230, 230,1)"
        keyboardAppearance="default"
        style={styles.passwordinput}
      ></TextInput>
      <View style={styles.forgetpasswordRow}>
        <View style={styles.forgetpassword}>
          <View style={styles.fpbg}>
            <TextInput
              placeholder="Forget Password"
              style={styles.fptext}
            ></TextInput>
          </View>
        </View>
        <View style={styles.summitlogin}>
          <View style={styles.bg}>
            <Text style={styles.login2}>LOGIN</Text>
          </View>
        </View>
      </View>
      <View style={styles.rect2}></View>
    </View>
  </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "rgba(35,39,42,1)"
  },
  main: {
    alignItems: "center",
    justifyContent: "center",
  },
  lands: {
    width: 319,
    height: 39,
    flexDirection: "row",
    justifyContent: "space-between"
  },
  loginbtn: {
    width: 137,
    height: 39
  },
  rect: {
    width: 137,
    height: 39,
    backgroundColor: "rgba(243,156,18,1)",
    borderRadius: 25
  },
  login: {
    fontFamily: "roboto-regular",
    color: "rgba(36,62,82,1)",
    fontSize: 25,
    width: 96,
    height: 30,
    opacity: 0.9,
    textAlign: "center",
    marginTop: 5,
    marginLeft: 21
  },
  regbtn: {
    width: 137,
    height: 39
  },
  regbg: {
    width: 137,
    height: 39,
    backgroundColor: "rgba(241,196,15,1)",
    borderRadius: 25
  },
  signUp: {
    fontFamily: "roboto-regular",
    color: "rgba(36,62,82,1)",
    fontSize: 25,
    width: 110,
    height: 30,
    textAlign: "center",
    marginTop: 5,
    marginLeft: 14
  },
  hr1: {
    width: 319,
    height: 5,
    backgroundColor: "#E6E6E6",
    marginTop: 19
  },
  emailinput: {
    fontFamily: "roboto-regular",
    color: "#121212",
    backgroundColor: "rgba(255,255,255,1)",
    borderWidth: 1,
    borderColor: "rgba(255,255,255,1)",
    borderRadius: 39,
    width: 319,
    letterSpacing: 0,
    textAlign: "center",
    height: 48,
    marginTop: 28
  },
  passwordinput: {
    fontFamily: "roboto-regular",
    color: "#121212",
    backgroundColor: "rgba(255,255,255,1)",
    borderWidth: 1,
    borderColor: "rgba(255,255,255,1)",
    borderRadius: 39,
    width: 319,
    letterSpacing: 0,
    textAlign: "center",
    height: 48,
    marginTop: 26
  },
  forgetpassword: {
    width: 141,
    height: 39
  },
  fpbg: {
    width: 141,
    height: 39,
    backgroundColor: "rgba(35,39,42,1)"
  },
  fptext: {
    fontFamily: "roboto-regular",
    color: "#121212",
    width: 105,
    height: 17,
    marginTop: 11,
    marginLeft: 18
  },
  summitlogin: {
    width: 141,
    height: 39,
    marginLeft: 37
  },
  bg: {
    backgroundColor: "rgba(241,196,15,1)",
    borderRadius: 36,
    flex: 1
  },
  login2: {
    fontFamily: "roboto-regular",
    color: "rgba(35,39,42,1)",
    fontSize: 25,
    textAlign: "center",
    width: 91,
    height: 30,
    marginTop: 5,
    marginLeft: 25
  },
  forgetpasswordRow: {
    height: 39,
    flexDirection: "row",
    marginTop: 26
  },
  rect2: {
    width: 319,
    height: 5,
    backgroundColor: "#E6E6E6",
    marginTop: 17,
    alignSelf: "center"
  }
});

export default App;
