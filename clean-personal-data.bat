@echo first install an extension as Admin or with --user: pip install git-filter-repo --user
@pause
python -m git_filter_repo --blob-callback %~dp0clean_history.py --force
@pause
@pause
git remote add origin https://github.com/ngdadu/WebAppTest
@pause
@pause
git push origin --all --force
@pause
@pause