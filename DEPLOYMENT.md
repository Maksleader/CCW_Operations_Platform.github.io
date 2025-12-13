# GitHub Pages Deployment

This repository is configured to deploy automatically to GitHub Pages.

## Deployment Setup

### 1. Configure Backend API URL (IMPORTANT)

Before deploying, you **must** update the backend API URL in:
- `angular/src/assets/appconfig.production.json`

Change:
```json
"remoteServiceBaseUrl": "https://localhost:44301",
```

To your actual production API URL:
```json
"remoteServiceBaseUrl": "https://your-api-domain.com",
```

⚠️ **Note:** The default localhost URL will not work in production and will cause CORS errors.

### 2. Enable GitHub Pages

1. Go to your repository settings on GitHub
2. Navigate to **Settings** > **Pages**
3. Under **Build and deployment**, set:
   - **Source**: GitHub Actions

### 3. Automatic Deployment

The deployment workflow is triggered automatically when you push to the `main` or `master` branch. You can also trigger it manually from the **Actions** tab.

### 4. Configuration

The Angular application is built from the `angular` directory and deployed to GitHub Pages. The build process:

1. Installs dependencies using Yarn
2. Builds the Angular application in production mode
3. Deploys the `dist` folder to GitHub Pages

### 5. Accessing Your Site

Once deployed, your site will be available at:
- `https://maksleader.github.io/`

### 6. Backend API Configuration (Reminder)

The application is configured to connect to a backend API. You may need to update the API URLs in:
- `angular/src/assets/appconfig.production.json`

Update the `remoteServiceBaseUrl` and `appBaseUrl` to point to your production API and deployed site.

### Manual Deployment

You can also trigger deployment manually:
1. Go to the **Actions** tab
2. Select **Deploy to GitHub Pages**
3. Click **Run workflow**
4. Select the branch and click **Run workflow**

## Build Locally

To build the project locally:

```bash
cd angular
yarn install
yarn run publish
```

The built files will be in `angular/dist`.

## Troubleshooting

### Build Failures

If the build fails:
1. Check the **Actions** tab for error logs
2. Verify that all dependencies are properly specified
3. Ensure the API configuration is correct

### 404 Errors

If you get 404 errors:
1. Verify GitHub Pages is enabled in repository settings
2. Check that the source is set to "GitHub Actions"
3. Ensure the latest workflow run completed successfully

### CORS Errors

If you see CORS errors:
1. Update your backend API to allow requests from your GitHub Pages URL
2. Add the GitHub Pages URL to the CORS configuration

## Additional Notes

- The workflow uses Node.js 16 for compatibility with the project dependencies
- Build artifacts are cached to speed up subsequent builds
- The deployment uses GitHub's official Pages deployment actions
