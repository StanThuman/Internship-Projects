var express = require('express');
var app = express();
var passport = require('passport');
var path = require('path');
var sassMiddleware = require('node-sass-middleware');
var babelifyMiddleware = require('express-babelify-middleware');
var cookieParser = require('cookie-parser');
var session = require('express-session');
var db = require('./db/config/connect');
var bodyParser = require('body-parser');
var testdata = require('./db/testData');
var flash = require('connect-flash');

app.listen(3000, () => {
  console.log('Listening on port 3000');
});

//setup middlware
app.use(sassMiddleware({
  src: path.join(__dirname, 'styles'),
  dest: path.join(__dirname, 'public/styles'),
  debug: true,
  outputStyle: 'compressed',
  prefix: '/styles'
}));
app.use('/mdl', express.static('node_modules/material-design-lite'));
app.use('/styles', express.static('public/styles'));
app.use('/js', express.static('public/js'));
app.use('/lib', express.static('node_modules/angular'));
app.use(cookieParser());
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true}));
app.use(session({ secret: 'keyboard cat',
                    saveUninitialized: true,
                    resave: true}));
app.use(passport.initialize());
app.use(passport.session());
// app.use(flash());

app.set('view engine','pug');

require('./db/config/passport')(passport);

// db connection
db.connect('mongodb://localhost:27017/healthFitnessPenton');

//routes for mongo api
app.use('/', require('./Routes/routes'));
app.use('/profile', require('./Routes/ProfileRoute'));
app.use('/profile/workout', require('./Routes/WorkoutRoute'));
app.use('/profile/diet', require('./Routes/DietRoute'));
app.use('/posts', require('./Routes/PostRoute'));


//authentication config

//client error handler
app.use(function(err, req, res, next){
  console.error(err.stack);
  if(req.xhr){
    res.status(500).send({error: 'INTERNAL SERVER FAILURE'});
  } else{
    next(err);
  }
});

//catch all errors
app.use(function(err, req, res, next){
  res.status(500);
  res.render('error', {error: err});
});
