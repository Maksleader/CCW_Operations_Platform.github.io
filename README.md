# CCW Operations Platform

This is an Angular-based operations platform built with ASP.NET Zero.

## 🚀 GitHub Pages Deployment

This repository is configured for automatic deployment to GitHub Pages. See [DEPLOYMENT.md](DEPLOYMENT.md) for detailed instructions.

### Quick Start

1. **Enable GitHub Pages in Repository Settings:**
   - Go to **Settings** > **Pages**
   - Set **Source** to **GitHub Actions**

2. **Push to main/master branch** - The app will automatically build and deploy

3. **Access your site at:** `https://maksleader.github.io/`

### Configuration

Before deploying, you may need to update the API URLs in:
- `angular/src/assets/appconfig.production.json`

Update `remoteServiceBaseUrl` to point to your production backend API.

## 📁 Project Structure

- `/angular` - Angular frontend application
- `/aspnet-core` - ASP.NET Core backend
- `/ui-tests` - UI testing suite

## 🛠️ Local Development

### Angular App

```bash
cd angular
yarn install
yarn start
```

The app will run at `http://localhost:4200`

### Building for Production

```bash
cd angular
yarn run publish
```

Built files will be in `angular/dist`

## 📖 Documentation

- [Deployment Guide](DEPLOYMENT.md) - Complete deployment instructions
- [Angular README](angular/README.md) - Angular-specific documentation
- [ASP.NET Core README](aspnet-core/README.md) - Backend documentation

## 🔧 Technologies

- **Frontend:** Angular 13
- **Backend:** ASP.NET Core
- **UI Framework:** Metronic
- **Package Manager:** Yarn

## 📝 License

MIT
