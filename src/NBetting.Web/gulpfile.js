"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    browserify = require("browserify"),
    source = require("vinyl-source-stream");

var webroot = "./wwwroot/";

var paths = {
    app: webroot + "js/app/*.js",
    js: webroot + "js/**/*.js",
    minJs: webroot + "js/**/*.min.js",
    build: webroot + "js/build.js",
    css: webroot + "css/**/*.css",
    minCss: webroot + "css/**/*.min.css",
    concatJsDest: webroot + "js/site.js",
    concatCssDest: webroot + "css/site.min.css",
    main: webroot + "js/app/app.js"
};

var buildAppTaskName = 'build-app';
gulp.task(buildAppTaskName, function () {
    return browserify(paths.main)
        .bundle()
        .on("error", function (err) {
            console.log(err);
        })
        .pipe(source("site.js"))
        .pipe(gulp.dest(webroot + "js"));
});

gulp.task("default", [buildAppTaskName]);
