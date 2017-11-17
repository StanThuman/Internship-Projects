var express = require('express');
var exerciseRouter = express.Router();
var Workout = require('../models/workout');
//var createProfile = require('../testData');

//var db = require('../config/connect');



exerciseRouter.get('/all', function(req,res){
  console.log('getting all the Exercise palns');

  var date = new Date();
  var month = date.getMonth();
  var day = date.getDay();
  if(month < 10){
    month = '0' + month;
  }
  if(day < 10){
    day = '0' + day;
  }
  var currentDate = month + '-' + day + '-' + date.getFullYear();
  Workout.find({date: currentDate}, (err, workout) => {
    console.log('')
  });

});

exerciseRouter.post('/edit/workoutinfo', (req, res) => {
  //console.log(req);
  var date = new Date();
  var month = date.getMonth();
  var day = date.getDay();
  if(month < 10){
    month = '0' + month;
  }
  if(day < 10){
    day = '0' + day;
  }
  var currentDate = month + '-' + day + '-' + date.getFullYear();

  Workout.findOne({ 'author': req.user._id, 'date': currentDate },
    (err, exercisePlan) => {
      if(err)
        console.log('there was an error');

      if(exercisePlan){
        console.log('found it')
        var newExercise = {
          name: req.body.workoutInput1,
          duration: req.body.workoutInput2,
          type: req.body.workoutInput3
        };
        exercisePlan.exercises.push(newExercise);
        exercisePlan.save(err => {
          if(err)
            console.log('error updating exercise into profile');
        });
        res.redirect('/profile/workout');
      }
      else{
        //create workout plan for current date
        var newWorkoutPlan = new Workout({
          author: req.user._id,
          exercises: [{
            name: req.body.workoutInput1,
            duration: req.body.workoutInput2,
            type: req.body.workoutInput3
          }],
          date: currentDate,
        });
        console.log(newWorkoutPlan);
        newWorkoutPlan.save();
        res.redirect('/profile/workout');
      }

  });

});

//exerciseRouter.get('/');


module.exports = exerciseRouter;
