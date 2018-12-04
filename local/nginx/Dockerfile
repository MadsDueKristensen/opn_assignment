FROM nginx
COPY nginx.conf /etc/nginx/nginx.conf
COPY ./www /usr/share/nginx/html
COPY ./mycert/mydomain.crt /etc/nginx/ssl/
COPY ./mycert/mydomain.key /etc/nginx/ssl/