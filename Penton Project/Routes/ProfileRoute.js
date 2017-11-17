var express = require('express');
var router = express.Router();

var Profile = require('../db/models/profile.js');

//var db = require('../config/connect');
var Profile = require('../db/models/profile');

router.get('/userinfo', (req, res) => {
  var profileData = '';
  var userName = '';
  var isLoggedin = false;
  if(req.user){
    profileData = req.user;
      userName = req.user.firstName;
      isLoggedin = true;
  }
  console.log(profileData);
  res.render('userinfo', {
    title: 'User Info',
    profile: profileData,
    firstName: userName,
    isLoggedin: isLoggedin
  });
});

router.get('/edit/userinfo', (req, res) => {
  var isLoggedIn = false;
  if(req.user){
    isLoggedin = true;
  }
  res.render('editFitnessForm', {
    title: 'User Info',
    isLoggedin: isLoggedin
  });
});

router.post('/edit/userinfo', (req, res) => {
  // console.log('got it');
  Profile.findOne({ 'google.email': req.user.google.email}, (err, profile) => {
    if(req.user){
      profile.currentWeight = req.body.profileInput1;
    }
    if(req.user){
      profile.calorieGoal = req.body.profileInput2;
    }
    if(req.user){
      profile.goalWeight = req.body.profileInput3;
    }
    profile.save();
    res.redirect('/profile/userinfo');

  });
});

router.get('/all', function(req,res){
  Profile.find(function(err, profiles){

    res.send(createProfile());
  });
});

router.post('/addProfile', function(req, res){
  // console.log(req.body);

  var newProfile = createProfile();
  console.log(newProfile);
  newProfile.save();
  //   (err, newProfile) => {
  //   //if(err) return console.error(err);
  // });
  console.log('DATA SAVED');
});


//profileRouter.get('/');


module.exports = router;
